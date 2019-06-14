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
using TMS.Dialogs;
using TMS.Utilities;

namespace TMS
{
    public partial class CustomerRouteForm : Form
    {
        private BindingSource bs = new BindingSource();

        public CustomerRouteForm()
        {
            InitializeComponent();
            UISetter.SetGridAppearance(grd, grdRoute);
            InitializeGrid();
            Load += CustomerRouteForm_Load;
            grd.MouseClick += Grd_MouseClick;
            UISetter.SetButtonAppearance(btnSave);
            btnUndo.SetCancelButtonAppearance();

            //grd.RowPostPaint += EventHandler.AddDatagridViewRowHeaderNumber;

            #region Events

            {
                grdRoute.CellContentClick += GrdRoute_CellContentClick;
                btnSave.Click += BtnSave_Click;
                btnUndo.Click += BtnUndo_Click;
            }

            #endregion Events
        }

        private void GrdRoute_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdRoute.Columns["Customers"].Index)
            {
                using (var dialog = new RouteDialog(grdRoute.Rows[e.RowIndex].Cells["Route Id"].Value.ToString()))
                {
                    dialog.ShowDialog();
                }
            }
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            var dt = bs.DataSource as DataTable;

            dt.RejectChanges();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var dt = bs.DataSource as DataTable;

            if (dt.GetChanges(DataRowState.Modified) is null)
                return;

            var manager = new RouteManager();

            List<IUnit> customers = new List<IUnit>();
            foreach (DataRow row in dt.GetChanges(DataRowState.Modified).Rows)
            {
                var unit = new CustomerRouteUnit();
                unit.CustomerId = row["customer_id"].ToString();
                unit.RouteId = row["route"].ToString();
                unit.CustomerName = row["name"].ToString();
                unit.CustomerAddress = row["address"].ToString();
                customers.Add(unit);
            }
            //manager.Update(dt.GetChanges(DataRowState.Modified).Rows, RouteManager.InsertType.CustomerRoute);
            manager.Update(customers, RouteManager.InsertType.CustomerRoute);
            manager.RunScript();
            dt.AcceptChanges();
            MessageBox.Show("Saved!");
        }

        private void Grd_MouseClick(object sender, MouseEventArgs e)
        {
            var hit = grd.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.Cell && hit.ColumnIndex == grd.Columns["Route"].Index)
            {
                grd.BeginEdit(true);
            }
            else if (hit.Type == DataGridViewHitTestType.RowHeader)
            {
                grd.EndEdit();
            }
        }

        private void CustomerRouteForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadRoutes();
            BindToGridView();
        }

        private void InitializeGrid()
        {
            #region Customer Route

            {
                var col1 = new DataGridViewTextBoxColumn();
                col1.Name = "Customer Id";
                col1.HeaderText = "Customer ID";
                col1.DataPropertyName = "customer_id";
                col1.FillWeight = 50;
                col1.ReadOnly = true;
                grd.Columns.Add(col1);

                var col2 = new DataGridViewTextBoxColumn();
                col2.Name = "Customer Name";
                col2.HeaderText = "Customer Name";
                col2.DataPropertyName = "name";
                col2.ReadOnly = true;
                col2.FillWeight = 150;
                grd.Columns.Add(col2);

                var col3 = new DataGridViewTextBoxColumn();
                col3.Name = "Address";
                col3.HeaderText = "Address";
                col3.DataPropertyName = "address";
                col3.FillWeight = 200;
                col3.ReadOnly = true;
                grd.Columns.Add(col3);

                var col4 = new DataGridViewComboBoxColumn();
                col4.Name = "Route";
                col4.HeaderText = "Route";
                col4.DataPropertyName = "route";
                col4.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                col4.SetDataGridViewComboBox(Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetRoutesByCustomers", null), "route_code", "route_id");
                col4.DefaultCellStyle.NullValue = "No route";
                col4.SortMode = DataGridViewColumnSortMode.Automatic;
                col4.FillWeight = 50;
                grd.Columns.Add(col4);

                grd.RowTemplate.Height = 35;
                grd.AllowUserToAddRows = false;
                grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

            #endregion Customer Route

            #region Route

            {
                var col1 = new DataGridViewTextBoxColumn();
                col1.Name = "Route Id";
                col1.HeaderText = "Route Id";
                col1.DataPropertyName = "route_id";
                col1.Visible = false;
                col1.ReadOnly = true;
                grdRoute.Columns.Add(col1);

                var col2 = new DataGridViewTextBoxColumn();
                col2.Name = "Route";
                col2.HeaderText = "Route";
                col2.DataPropertyName = "route_code";
                grdRoute.Columns.Add(col2);

                var col3 = new DataGridViewTextBoxColumn();
                col3.Name = "Description";
                col3.HeaderText = "Description";
                col3.DataPropertyName = "description";
                grdRoute.Columns.Add(col3);

                var col4 = new DataGridViewLinkColumn();
                col4.Name = "Customers";
                col4.HeaderText = "Number of Customers";
                col4.DataPropertyName = "no. of Customers";
                col4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col4.TrackVisitedState = false;
                col4.LinkBehavior = LinkBehavior.NeverUnderline;
                col4.DefaultCellStyle.SelectionBackColor = Color.White;

                grdRoute.Columns.Add(col4);

                grdRoute.AllowUserToAddRows = false;
            }

            #endregion Route
        }

        private void LoadCustomers()
        {
            bs.DataSource = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetCustomers", null);
            bs.Sort = "Route ASC";
        }

        private void LoadRoutes()
        {
            grdRoute.DataSource = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetRoutesByCustomers", null);
        }

        private void BindToGridView()
        {
            grd.DataSource = bs;
        }
    }
}