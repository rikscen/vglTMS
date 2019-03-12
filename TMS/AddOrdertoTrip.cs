using Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TMS.Utilities;

namespace TMS
{
    public partial class AddOrdertoTrip : Form
    {
        public String trip_id = "";

        public AddOrdertoTrip()
        {
            InitializeComponent();
        }

        private void AddOrdertoTrip_Load(object sender, EventArgs e)
        {
            UISetter.SetButtonAppearance(btnAdd);
            UISetter.SetGridAppearance(header_grid);
            LoadTable();
        }

        private void LoadTable()
        {
            DataTable dt = Connection.GetOMSConnection.ExecuteDataSet("SELECT out_shipment_id, " +
                                                                        "CONVERT(varchar(10),document_reference_date,101) [Ref Doc Date], " +
                                                                        "document_reference[Ref Doc], " +
                                                                        "Client, " +
                                                                        "customer_id name, " +
                                                                        "'' Route, " +
                                                                        "SUM(osrd.expected_qty * osrd.price) [Doc Value], " +
                                                                        "tms_trip_id Trip " +
                                                                        "FROM OutgoingShipmentRequests osr " +
                                                                        "INNER JOIN dbo.OutgoingShipmentRequestDetails osrd ON osr.out_shipment_id = osrd.out_shipment " +
                                                                        "WHERE STATUS = 'FOR SCHEDULING' " +
                                                                        "GROUP BY osr.out_shipment_id, " +
                                                                        "osr.document_reference_date, " +
                                                                        "osr.document_reference, " +
                                                                        "client, " +
                                                                        "customer_id, " +
                                                                        "osr.tms_trip_id").Tables[0];
            DataTable dt2 = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetOutShipmentForScheduling", null);

            header_grid.DataSource = dt;//Connection.GetOMSConnection.ExecuteDataSet("SELECT out_shipment_id,document_reference_date[Ref Doc Date], document_reference [Ref Doc], Client, customer_id[Customer],''[Route], ''[Doc Value], tms_trip_id[Trip] FROM OutgoingShipmentRequests WHERE status ='FOR SCHEDULING'; ").Tables[0];
        }

        private void InitializeGrid()
        {
            var txtOutshipId = new DataGridViewTextBoxColumn();
            txtOutshipId.HeaderText = "Out Shipment Id";
            txtOutshipId.DataPropertyName = "out_shipment_id";
            header_grid.Columns.Add(txtOutshipId);

            var txtRefDocDate = new DataGridViewTextBoxColumn();
            txtRefDocDate.HeaderText = "Ref Doc Date";
            txtRefDocDate.DataPropertyName = "Ref Doc Date";
            txtRefDocDate.DefaultCellStyle.Format = "d";
            header_grid.Columns.Add(txtRefDocDate);

            var txtDocValue = new DataGridViewTextBoxColumn();
            txtDocValue.HeaderText = "Document Value";
            txtDocValue.DataPropertyName = "Doc Value";
            txtDocValue.DefaultCellStyle.Format = "N2";
            header_grid.Columns.Add(txtDocValue);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var row = header_grid.CurrentRow;
            // Update Itself
            {
                Dictionary<String, Object> dict = new Dictionary<string, object>();
                dict.Add("trip", trip_id);
                dict.Add("order_id", row.Cells["colShipId"].Value.ToString());
                dict.Add("client", row.Cells["colClient"].Value.ToString());
                dict.Add("customer", row.Cells["colCustomer"].Value.ToString());
                dict.Add("status", "FOR RECEIVING");
                dict.Add("reference", row.Cells["colRefDoc"].Value.ToString());
                dict.Add("reference_date", row.Cells["colRefDocDate"].Value.ToString());
                dict.Add("oms", row.Cells["colClient"].Value.ToString());
                dict.Add("doc_value", row.Cells["colDocValue"].Value.ToString());
                dict.Add("drop_sequence", FAQ.GetSequence(trip_id));

                String sql = DataSupport.GetInsert("TripOrders", dict);
                string s = row.Cells["colRoute"].Value.ToString();
                sql += " UPDATE Trips SET route = '" + row.Cells["colRoute"].Value.ToString() + "', last_updated_on ='" + DateTime.Now + "' WHERE trip_id = '" + trip_id + "' ";
                DataSupport.RunNonQuery(sql, IsolationLevel.ReadCommitted);
            }

            // Update OMS
            {
                String sql = " UPDATE OutgoingShipmentRequests SET status ='FOR RELEASING' WHERE out_shipment_id = '" + row.Cells["colShipId"].Value.ToString() + "'; ";
                Connection.GetOMSConnection.ExecuteNonQuery(sql, IsolationLevel.ReadCommitted);
            }

            // Update WMS
            {
                // Sync the trip
                String sql = Utils.GetTripWMSSyncSQL(trip_id);

                // Sync the orders of the trip
                var tripDetailsDT = Utils.GetTripDetails(trip_id);
                var tripHeaderRow = Utils.GetTripHeader(trip_id);

                foreach (DataRow trip_row in tripDetailsDT.Rows)
                    sql += $"UPDATE ReleaseOrders SET status='FOR PICKING', scheduled_release_date = '{ tripHeaderRow["expected_start"] }' WHERE order_id ='{ trip_row["order_id"] }' AND status='FOR SCHEDULING';";

                Connection.GetWMSConnection.ExecuteNonQuery(sql, IsolationLevel.ReadCommitted);
            }

            LoadTable();
        }
    }
}