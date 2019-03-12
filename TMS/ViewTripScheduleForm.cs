using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TMS.DataManager;
using TMS.DataUnit;
using TMS.Utilities;

namespace TMS
{
    public partial class ViewTripScheduleForm : Form
    {
        private TripUnit Unit { get; set; }
        private DataTable orders = new DataTable();

        public ViewTripScheduleForm(TripUnit unit)
        {
            InitializeComponent();
            Unit = unit;
        }

        private void ViewTripScheduleForm_Load(object sender, EventArgs e)
        {
            UISetter.SetButtonAppearance(btnSave, btnAdd, btnSelectedOrder, btnBack);
            UISetter.SetLabelAppearance(lblTripOverview, lblOrder, lblScheduleOrder);
            var dt = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetRoutes", null);
            cbRoute.SetComboBox(dt, "route_code", "route_id");

            lblTripNo.Text = Unit.TripId;
            lblVehicle.Text = Unit.VehicleId;
            lblTripStart.Text = Unit.ExpectedStart;
            lblTripEnd.Text = Unit.ExpectedEnd;
            lblIncharge.Text = Unit.Incharge;
            cbRoute.SelectedValue = Unit.RouteId;
            lblLastUpdated.Text = Unit.LastUpdated;

            grdOrders.SetGridAppearance();
            grd.SetGridAppearance();
            LoadOrders();
            grdOrders.ClearSelection();
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

        private void LoadOrderForScheduling()
        {
            grd.DataSource = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetOutShipmentForScheduling", null);
            grd.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (pnTripOverview.Visible && !pnOrder.Visible)
            {
                pnTripOverview.Visible = false;
                pnOrder.Visible = true;
                LoadOrderForScheduling();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!pnTripOverview.Visible && pnOrder.Visible)
            {
                pnTripOverview.Visible = true;
                pnOrder.Visible = false;
            }
        }

        private void btnSelectedOrder_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            var param = new Dictionary<string, object>();
            orders = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetOutShipmentForScheduling", null).Clone();

            if (grd.SelectedRows.Count == 0)
            {
                MessageBox.Show("No orders selected. Please select orders.");
                return;
            }

            for (int i = grd.SelectedRows.Count - 1; i >= 0; i--)
            {
                param.Add("@id", grd.SelectedRows[i].Cells["colShipId2"].Value.ToString());
                param.Add("@flag", true);

                orders.ImportRow(Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetOutShipmentForScheduling", param).Rows[0]);
                param.Clear();
            }
            LoadOrders();
            grdOrders.ClearSelection();
            pnTripOverview.Visible = true;
            pnOrder.Visible = false;
        }
    }
}