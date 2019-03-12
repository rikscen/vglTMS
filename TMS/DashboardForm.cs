using Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TMS.DataUnit;
using TMS.Utilities;

namespace TMS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            tc.DrawItem += UISetter.TabControl_DrawItem;
        }

        //private void LoadTrips()
        //{
        //    DateTime start = DateTime.Now.Date;

        //    var param = new Dictionary<string, object>();
        //    param.Add("@date", start);

        //    foreach (DataRow row in Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetVehicleWithTripSchedule", param).Rows)
        //    {
        //        Button btn = new Button();
        //        btn.Click += new EventHandler(VehicleButtonClick);
        //        btn.Text = row["vehicle"].ToString();
        //        btn.Tag = row["trip_id"];
        //        btn.Size = new Size(150, 30);
        //        btn.SetButtonAppearance();
        //        flp.Controls.Add(btn);
        //    }
        //}

        private void LoadOrder()
        {
            grd.DataSource = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetOutShipmentForScheduling", null);
        }

        private void LoadTrips(int flag)
        {
            DateTime start = DateTime.Now.Date.AddDays(1);
            var param = new Dictionary<string, object>();
            switch (flag)
            {
                //ALL
                case 1:
                    param.Add("@date", start);
                    param.Add("@flag", flag);
                    break;
                //WITH ORDERS
                case 2:
                    param.Add("@date", start);
                    param.Add("@flag", flag);
                    break;
                //NO ORDERS
                case 3:
                    param.Add("@date", start);
                    param.Add("@flag", flag);
                    break;
            }

            grdVehicleWithTrip.DataSource = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetVehicleWithTripSchedule", param);
        }

        private void VehicleButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            using (var dialog = new ManageTrips())
            {
                dialog.trip_id = btn.Tag.ToString();
                dialog.ShowDialog();
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            UISetter.SetLabelAppearance(label1, label2, lblSchedules);
            UISetter.SetButtonAppearance(btnSchedule, btnCreateTrip);
            tc.DrawMode = TabDrawMode.OwnerDrawFixed;
            grd.SetGridAppearance();
            grdVehicleWithTrip.SetGridAppearance();
            LoadTrips(1);
            LoadOrder();
        }

        //private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var col = grd.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
        //    if (col == null)
        //        return;

        //    var cell = grd.CurrentCell as DataGridViewButtonCell;
        //    if (cell != null)
        //    {
        //    }
        //}

        //private void grd_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        //{
        //    //if (e.RowIndex > -1 && e.ColumnIndex == grd.Rows[e.RowIndex].Cells["colOption"].ColumnIndex)
        //    //{
        //    //    var row = grd.Rows[e.RowIndex];

        //    //    // Add the employee's ID to the ToolTipText.
        //    //    e.ToolTipText = "Click to schedule order";
        //    //}
        //}

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            var param = new Dictionary<string, object>();
            var dt = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetOutShipmentForScheduling", null).Clone();

            if (grd.SelectedRows.Count == 0)
            {
                MessageBox.Show("No orders selected. Please select orders.");
                return;
            }

            //foreach (DataGridViewRow row in grd.SelectedRows)
            //{
            //    sb.AppendFormat(",'{0}'", row.Cells["colShipId"].Value.ToString());
            //}

            for (int i = grd.SelectedRows.Count - 1; i >= 0; i--)
            {
                //sb.AppendFormat(",'{0}'", grd.SelectedRows[i].Cells["colShipId"].Value.ToString());
                param.Add("@id", grd.SelectedRows[i].Cells["colShipId"].Value.ToString());
                param.Add("@flag", true);

                dt.ImportRow(Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetOutShipmentForScheduling", param).Rows[0]);
                param.Clear();
            }
            //sb.Remove(0, 1);
            using (var dialog = new CreateScheduleForm(dt))
            {
                //param.Add("@param", sb.ToString());
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                {
                    LoadOrder();
                }
            }
        }

        private void DashboardForm_Shown(object sender, EventArgs e)
        {
            grd.ClearSelection();
            grdVehicleWithTrip.ClearSelection();
        }

        private void tc_Selected(object sender, TabControlEventArgs e)
        {
            TabPage tp = e.TabPage;
            if (tp == tpSchedule)
            {
                LoadTrips(1);
            }
            else if (tp == tpOrders)
            {
                LoadOrder();
            }
        }

        private void grdVehicleWithTrip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grd = sender as DataGridView;
            if (grd.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var unit = new TripUnit();
                unit.TripId = grd.Rows[e.RowIndex].Cells["colTripId"].Value.ToString();
                unit.VehicleId = grd.Rows[e.RowIndex].Cells["colVehicle"].Value.ToString();
                unit.ExpectedStart = DateTime.Parse(grd.Rows[e.RowIndex].Cells["colExpectedStart"].Value.ToString()).ToShortDateString();
                unit.ExpectedEnd = DateTime.Parse(grd.Rows[e.RowIndex].Cells["colExpectedEnd"].Value.ToString()).ToShortDateString();
                unit.Incharge = grd.Rows[e.RowIndex].Cells["colIncharge"].Value.ToString();
                unit.RouteId = grd.Rows[e.RowIndex].Cells["colRoute"].Value.ToString();
                unit.LastUpdated = grd.Rows[e.RowIndex].Cells["colLastUpdated"].Value.ToString();

                using (var dialog = new ViewTripScheduleForm(unit))
                {
                    dialog.ShowDialog();
                }
            }
        }

        private void btnCreateTrip_Click(object sender, EventArgs e)
        {
            using (var dialog = new CreateTripForm())
            {
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                {
                    LoadTrips(1);
                }
            }
        }

        private void rbAllTrips_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllTrips.Checked)
                LoadTrips(1);
        }

        private void rbWithOrders_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWithOrders.Checked)
                LoadTrips(2);
        }

        private void rbWithNoOrders_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWithNoOrders.Checked)
                LoadTrips(3);
        }
    }
}