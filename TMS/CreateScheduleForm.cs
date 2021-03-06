﻿using Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TMS.DataManager;
using TMS.DataUnit;
using TMS.Utilities;

namespace TMS
{
    public partial class CreateScheduleForm : Form
    {
        private DataTable orders;

        public CreateScheduleForm(DataTable dt)
        {
            InitializeComponent();
            Size = new Size(1100, 600);
            orders = dt;
        }

        private void CreateScheduleForm_Load(object sender, EventArgs e)
        {
            UISetter.SetLabelAppearance(label1, lblOrder, lblTripOverview);
            UISetter.SetButtonAppearance(btnCreateTrip, btnBack, btnNav);

            var dt = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetRoutes", null);
            cbRoute.SetComboBox(dt, "route_code", "route_id");

            grdVehicleWithTrip.SetGridAppearance();
            grdOrders.SetGridAppearance();
            LoadTrips(1);
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

        private void LoadOrders()
        {
            grdOrders.Rows.Clear();

            var param = new Dictionary<string, object>();
            param.Add("@trip_id", lblTripNo.Text);

            int dropSequence = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetTripOrders", param).Rows.Count + 1;
            //if (dropSequence == 0)
            //    dropSequence += 1;
            foreach (DataRow row in Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetTripOrders", param).Rows)
            {
                grdOrders.Rows.Add(row["drop_sequence"],
                                   row["out_shipment_id"],
                                   row["Ref Doc Date"],
                                   row["Ref Doc"],
                                   row["Client"],
                                   row["customer_id"],
                                   row["name"],
                                   row["doc_value"]
                                   );
            }
            foreach (DataRow row in orders.Rows)
            {
                grdOrders.Rows.Add(dropSequence.ToString(),
                                   row["out_shipment_id"],
                                   row["Ref Doc Date"],
                                   row["Ref Doc"],
                                   row["Client"],
                                   row["customer_id"],
                                   row["name"],
                                   row["doc value"]
                                   );
                dropSequence += 1;
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

        private void grdVehicleWithTrip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grd = sender as DataGridView;
            if (grd.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (pnAvailable.Visible && !pnTripOverview.Visible)
                {
                    pnAvailable.Visible = false;
                    pnTripOverview.Visible = true;
                    lblTripNo.Text = grd.Rows[e.RowIndex].Cells["colTripId"].Value.ToString();
                    lblVehicle.Text = grd.Rows[e.RowIndex].Cells["colVehicle"].Value.ToString();
                    lblTripStart.Text = DateTime.Parse(grd.Rows[e.RowIndex].Cells["colExpectedStart"].Value.ToString()).ToShortDateString();
                    lblTripEnd.Text = DateTime.Parse(grd.Rows[e.RowIndex].Cells["colExpectedEnd"].Value.ToString()).ToShortDateString();
                    lblIncharge.Text = grd.Rows[e.RowIndex].Cells["colIncharge"].Value.ToString();
                    cbRoute.SelectedValue = grd.Rows[e.RowIndex].Cells["colRoute"].Value;
                    lblLastUpdated.Text = grd.Rows[e.RowIndex].Cells["colLastUpdated"].Value.ToString();
                    LoadOrders();
                    grdOrders.ClearSelection();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!pnAvailable.Visible && pnTripOverview.Visible)
            {
                pnAvailable.Visible = true;
                pnTripOverview.Visible = false;
            }
        }

        private void CreateScheduleForm_Shown(object sender, EventArgs e)
        {
            grdOrders.ClearSelection();
            grdVehicleWithTrip.ClearSelection();
        }

        private void btnNav_Click(object sender, EventArgs e)
        {
            if (cbRoute.SelectedIndex == -1)
            {
                MessageBox.Show("Select Route");
                return;
            }

            var manager = new TripManager();
            var tripUnit = new TripUnit();

            tripUnit.TripId = lblTripNo.Text;
            tripUnit.ExpectedStart = lblTripStart.Text;
            tripUnit.ExpectedEnd = lblTripEnd.Text;
            tripUnit.Incharge = lblIncharge.Text;
            tripUnit.VehicleId = lblVehicle.Text;
            tripUnit.RouteId = cbRoute.SelectedValue.ToString();
            tripUnit.ActualStart = "";
            tripUnit.ActualEnd = "";
            tripUnit.Cost = "";
            tripUnit.LastUpdated = DateTime.Now.Date.ToShortDateString();
            manager.InsertTrip(tripUnit);

            manager.WMSHeaderInsert(lblTripNo.Text, lblIncharge.Text);
            foreach (DataGridViewRow row in grdOrders.Rows)
            {
                var tripOrderUnit = new TripOrderUnit();
                tripOrderUnit.DropSequence = row.Cells["colDropSequence"].Value.ToString();
                tripOrderUnit.TripId = lblTripNo.Text;
                tripOrderUnit.OrderId = row.Cells["colShipId"].Value.ToString();
                tripOrderUnit.Reference = row.Cells["colRefDoc"].Value.ToString();
                tripOrderUnit.ReferenceDate = row.Cells["colRefDocDate"].Value.ToString();
                tripOrderUnit.ClientId = row.Cells["colClient"].Value.ToString();
                tripOrderUnit.CustomerId = row.Cells["colCustId"].Value.ToString();
                tripOrderUnit.OrderManagementSystem = row.Cells["colClient"].Value.ToString();
                tripOrderUnit.DocumentValue = row.Cells["colDocValue"].Value.ToString();
                tripOrderUnit.CustomerDeliveryAddress = "";
                tripOrderUnit.Remarks = "";
                tripOrderUnit.Status = "FOR RECEIVING";
                manager.InsertTripOrder(tripOrderUnit);

                manager.UpdateOutgoingShipmentRequest("out_shipment_id", tripOrderUnit.OrderId);
                manager.WMSDetailsInsert(tripOrderUnit.TripId, tripOrderUnit.OrderId, tripOrderUnit.DropSequence, lblTripStart.Text);
            }
            manager.RunScript();

            MessageBox.Show("SAVED");

            DialogResult = DialogResult.OK;
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