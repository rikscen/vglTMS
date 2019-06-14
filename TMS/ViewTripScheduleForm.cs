using Microsoft.Reporting.WinForms;
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
using TMS.Printing;
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
            InitializeGrid();
            btnPrint2.Click += BtnPrint2_Click;
        }

        private void InitializeGrid()
        {
            #region Trip Orders

            {
                grdOrders.Columns.AddRange(
                new DataGridViewTextBoxColumn
                {
                    Name = "Drop Sequence",
                    HeaderText = "Drop Seq.",
                    DataPropertyName = "drop_sequence",
                    DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight },
                    ReadOnly = true,
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Outshipment Id",
                    DataPropertyName = "out_shipment_id",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Ref Doc Date",
                    DataPropertyName = "Ref Doc Date",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Ref Doc",
                    DataPropertyName = "Ref Doc",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Client",
                    DataPropertyName = "client",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Customer",
                    DataPropertyName = "customer_id",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Name",
                    DataPropertyName = "name",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Route",
                    DataPropertyName = "route",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Doc Value",
                    DataPropertyName = "doc_value",
                    ReadOnly = true,
                    DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
                });
                grdOrders.AutoGenerateColumns = false;
                grdOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            #endregion Trip Orders

            #region Schedule Orders

            {
                grd.Columns.AddRange(
                new DataGridViewTextBoxColumn
                {
                    Name = "Outshipment Id",
                    DataPropertyName = "out_shipment_id",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Ref Doc Date",
                    DataPropertyName = "Ref Doc Date",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Ref Doc",
                    DataPropertyName = "Ref Doc",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Client",
                    DataPropertyName = "client",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Customer",
                    DataPropertyName = "customer_id",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Name",
                    DataPropertyName = "name",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Route",
                    DataPropertyName = "route",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Doc Value",
                    DataPropertyName = "doc value",
                    ReadOnly = true,
                    DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
                });
                grd.AutoGenerateColumns = false;
                grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            #endregion Schedule Orders
        }

        private void BtnPrint2_Click(object sender, EventArgs e)
        {
            List<ReportDataSource> reports = new List<ReportDataSource>();
            var param = new Dictionary<string, object>();
            param.Add("trip_id", lblTripNo.Text);

            var dt2 = Connection.GetTMSConnection.ExecuteStoredProcedure("sp_gettriporders2", param);

            reports.Add(new ReportDataSource("tripdetail", dt2));

            using (var dialog = new PrintForm2(reports))
            {
                dialog.ShowDialog();
            }
        }

        private void ViewTripScheduleForm_Load(object sender, EventArgs e)
        {
            UISetter.SetButtonAppearance(btnSave, btnAdd, btnSelectedOrder, btnBack, btnPrint);
            UISetter.SetLabelAppearance(lblTripOverview, lblOrder, lblScheduleOrder);
            var dt = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetRoutes", null);
            //cbRoute.SetComboBox(dt, "route_code", "route_id");

            lblTripNo.Text = Unit.TripId;
            lblVehicle.Text = Unit.VehicleId;
            lblplate.Text = Unit.plateno;
            lblTripStart.Text = Unit.ExpectedStart;
            lblTripEnd.Text = Unit.ExpectedEnd;
            lblIncharge.Text = Unit.Incharge;
            //cbRoute.SelectedValue = Unit.RouteId;
            lblLastUpdated.Text = Unit.LastUpdated;
            lblDriver.Text = Unit.Driver;
            lblHelper1.Text = Unit.Helper1;
            lblHelper2.Text = Unit.Helper2;
            lblHelper3.Text = Unit.Helper3;
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
                                   row["route"],
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
                                   row["route"],
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
            //if (cbRoute.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Select Route");
            //    return;
            //}

            var manager = new TripManager();
            var tripUnit = new TripUnit();

            tripUnit.TripId = lblTripNo.Text;
            tripUnit.ExpectedStart = lblTripStart.Text;
            tripUnit.ExpectedEnd = lblTripEnd.Text;
            tripUnit.Incharge = lblIncharge.Text;
            tripUnit.VehicleId = lblVehicle.Text;
            tripUnit.RouteId = "Metro Butuan";
            tripUnit.ActualStart = "";
            tripUnit.ActualEnd = "";
            tripUnit.Cost = "";
            tripUnit.LastUpdated = DateTime.Now.Date.ToShortDateString();
            tripUnit.Driver = lblDriver.Text;
            tripUnit.Helper1 = lblHelper1.Text;
            tripUnit.Helper2 = lblHelper2.Text;
            tripUnit.Helper3 = lblHelper3.Text;
            manager.InsertTrip(tripUnit);

            manager.WMSHeaderInsert(lblTripNo.Text, lblIncharge.Text);
            foreach (DataGridViewRow row in grdOrders.Rows)
            {
                var tripOrderUnit = new TripOrderUnit();
                tripOrderUnit.DropSequence = row.Cells["Drop Sequence"].Value.ToString();
                tripOrderUnit.TripId = lblTripNo.Text;
                tripOrderUnit.OrderId = row.Cells["Outshipment Id"].Value.ToString();
                tripOrderUnit.Reference = row.Cells["Ref Doc"].Value.ToString();
                tripOrderUnit.ReferenceDate = row.Cells["Ref Doc Date"].Value.ToString();
                tripOrderUnit.ClientId = row.Cells["Client"].Value.ToString();
                tripOrderUnit.CustomerId = row.Cells["Customer"].Value.ToString();
                tripOrderUnit.OrderManagementSystem = row.Cells["Client"].Value.ToString();
                tripOrderUnit.DocumentValue = row.Cells["Doc Value"].Value.ToString();
                tripOrderUnit.CustomerDeliveryAddress = "";
                tripOrderUnit.Remarks = "";
                tripOrderUnit.Status = "FOR RECEIVING";
                manager.InsertTripOrder(tripOrderUnit);


                foreach(DataRow drow in Connection.GetOMSConnection.ExecuteDataSet("SELECT * FROM OutgoingShipmentRequestDetails WHERE").Tables[0].Rows)
                {

                }



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
                param.Add("@id", grd.SelectedRows[i].Cells["Outshipment Id"].Value.ToString());
                param.Add("@flag", true);

                orders.ImportRow(Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetOutShipmentForScheduling", param).Rows[0]);
                param.Clear();
            }
            LoadOrders();
            grdOrders.ClearSelection();
            pnTripOverview.Visible = true;
            pnOrder.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var doc = new crTrip();
            var dt = new DataTable();
            var sb = new StringBuilder();
            var field = new CrystalDecisions.Shared.ParameterValues();
            dt.Columns.Add("tripno");
            dt.Columns.Add("vehicle");
            dt.Columns.Add("tripstart",typeof(DateTime));
            dt.Columns.Add("tripend", typeof(DateTime));
            dt.Columns.Add("incharge");
            dt.Columns.Add("route");
            dt.Columns.Add("driver");
            dt.Columns.Add("helper1");
            dt.Columns.Add("helper2");
            dt.Columns.Add("helper3");
            dt.Columns.Add("totalqty");

            //dt.Rows.Add(lblTripNo.Text, lblVehicle.Text, lblTripStart.Text, lblTripEnd.Text, lblIncharge.Text, cbRoute.Text, lblDriver.Text,
            //            string.IsNullOrEmpty(lblHelper2.Text) ? lblHelper1.Text : lblHelper1.Text + ", ", string.IsNullOrEmpty(lblHelper3.Text) ? lblHelper2.Text : lblHelper2.Text + ", ", lblHelper3.Text);
            dt.Rows.Add(lblTripNo.Text, lblVehicle.Text + " - " + lblplate.Text, lblTripStart.Text, lblTripEnd.Text, lblIncharge.Text, "", lblDriver.Text,
            string.IsNullOrEmpty(lblHelper2.Text) ? lblHelper1.Text : lblHelper1.Text + ", ", string.IsNullOrEmpty(lblHelper3.Text) ? lblHelper2.Text : lblHelper2.Text + ", ", lblHelper3.Text);


            var param = new Dictionary<string, object>();
            param.Add("trip_id", lblTripNo.Text);

            doc.Database.Tables["TripHeader"].SetDataSource(dt);

            int count = 0;
            foreach (DataRow row in Connection.GetTMSConnection.ExecuteStoredProcedure("sp_gettriporderroutes", param).Rows)
            {
                sb.Append(row["route"]);

                if (count != Connection.GetTMSConnection.ExecuteStoredProcedure("sp_gettriporderroutes", param).Rows.Count - 1)
                    sb.Append(", ");
                count++;
            }
            var dt2 = Connection.GetTMSConnection.ExecuteStoredProcedure("sp_gettriporders2", param);
            DataColumn col = new DataColumn("qty");
            Dictionary<String, int> uomqty = new Dictionary<string, int>();            
            col.DefaultValue = "CASE = 3";
            dt2.Columns.Add(col);


            doc.Database.Tables["TripDetail"].SetDataSource(dt2);

            doc.SetParameterValue("routes", sb.ToString());
            using (var dialog = new PrintForm())
            {
                dialog.viewer.ReportSource = doc;
                dialog.ShowDialog();
            }
        }
    }
}