using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.DataManager;
using TMS.DataUnit;
using TMS.Utilities;
using VGLHelper;

namespace TMS.Dialogs
{
    public partial class RouteDialog : Form
    {
        private string route = "";

        public RouteDialog(string route)
        {
            InitializeComponent();
            UISetter.SetLabelAppearance(lblRoute);
            UISetter.SetGridAppearance(grd);
            UISetter.SetButtonAppearance(btnAdd, btnSave);
            UISetter.SetCancelButtonAppearance(btnRemove);
            UISetter.SetCancelButtonAppearance(btnCancel);
            InitializeGrid();
            LoadCustomers(route);
            lblRoute.Text += route;
            this.route = route;

            #region Events

            {
                grd.UserDeletingRow += Grd_UserDeletingRow;
                btnAdd.Click += BtnAdd_Click;
                btnSave.Click += BtnSave_Click;
                btnRemove.Click += BtnRemove_Click;
                btnCancel.Click += BtnCancel_Click;
            }

            #endregion Events
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var dt = grd.DataSource as DataTable;

            if (dt.GetChanges() is null)
            {
                MessageBox.Show("No changes made.");
                return;
            }

            var response = MessageBox.Show($"Are you sure you want to cancel any changes made?", "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response == DialogResult.No)
                return;

            dt.RejectChanges();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var dt = grd.DataSource as DataTable;
            var manager = new RouteManager();
            List<IUnit> customers;
            var result = new StringBuilder();

            if (dt.GetChanges(DataRowState.Deleted) != null)
            {
                result.AppendLine("DELETED ROWS:");
                customers = new List<IUnit>();
                foreach (DataRow row in dt.GetChanges(DataRowState.Deleted).Rows)
                {
                    var unit = new CustomerRouteUnit();
                    unit.CustomerId = row["customer_id", DataRowVersion.Original].ToString();
                    unit.RouteId = "NR";
                    unit.CustomerName = row["name", DataRowVersion.Original].ToString();
                    unit.CustomerAddress = row["address", DataRowVersion.Original].ToString();
                    customers.Add(unit);
                }
                manager.Update(customers, RouteManager.InsertType.CustomerRoute);
            }

            if (dt.GetChanges(DataRowState.Modified) != null)
            {
                result.AppendLine("MODIFIED ROWS:");
                customers = new List<IUnit>();
                foreach (DataRow row in dt.GetChanges(DataRowState.Modified).Rows)
                {
                    var unit = new CustomerRouteUnit();
                    unit.CustomerId = row["customer_id"].ToString();
                    unit.RouteId = route;
                    unit.CustomerName = row["name"].ToString();
                    unit.CustomerAddress = row["address"].ToString();
                    customers.Add(unit);
                }
                manager.Update(customers, RouteManager.InsertType.CustomerRoute);
            }

            if (dt.GetChanges(DataRowState.Added) != null)
            {
                result.AppendLine("ADDED ROWS:");
                customers = new List<IUnit>();
                foreach (DataRow row in dt.GetChanges(DataRowState.Added).Rows)
                {
                    var unit = new CustomerRouteUnit();
                    unit.CustomerId = row["customer_id"].ToString();
                    unit.RouteId = route;
                    unit.CustomerName = row["name"].ToString();
                    unit.CustomerAddress = row["address"].ToString();
                    customers.Add(unit);
                }
                manager.Insert(customers, RouteManager.InsertType.CustomerRoute);
            }

            //using (var dialog = new SummaryDialog(result.ToString()))
            //{
            //}

            manager.RunScript();
            dt.AcceptChanges();
            MessageBox.Show("Saved!");
        }

        private void Grd_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var response = MessageBox.Show($"Are you sure you want to remove { grd.CurrentRow.Cells["Name"].Value } from { lblRoute.Text }?", "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response == DialogResult.No)
                e.Cancel = true;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show($"Are you sure you want to remove { grd.CurrentRow.Cells["Name"].Value } from { lblRoute.Text }?", "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response == DialogResult.No)
                return;
            grd.Rows.RemoveAt(grd.CurrentRow.Index);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            grd.CurrentCell = grd.Rows[grd.Rows.Count - 1].Cells["Customer Id"];
            grd.BeginEdit(true);
        }

        private void LoadCustomers(string route)
        {
            var param = new Dictionary<string, object>();
            param.Add("@route", route);
            grd.DataSource = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetCustomersByRoute", param);
        }

        private void InitializeGrid()
        {
            var col1 = new DataGridViewTextBoxColumn();
            col1.Name = "Customer Id";
            col1.HeaderText = "Customer Id";
            col1.DataPropertyName = "customer_id";
            col1.FillWeight = 100;
            grd.Columns.Add(col1);

            var col2 = new DataGridViewTextBoxColumn();
            col2.Name = "Name";
            col2.HeaderText = "Customer Name";
            col2.DataPropertyName = "name";
            col2.FillWeight = 200;
            grd.Columns.Add(col2);

            var col3 = new DataGridViewTextBoxColumn();
            col3.Name = "Address";
            col3.HeaderText = "Address";
            col3.DataPropertyName = "address";
            col3.FillWeight = 300;
            grd.Columns.Add(col3);

            //var col4 = new DataGridViewButtonColumn();
            //col4.Name = "Action";
            //col4.HeaderText = "Action";
            //col4.DataPropertyName = "action";
            //col4.Text = "View";
            //grd.Columns.Add(col4);
            grd.MultiSelect = false;
            grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}