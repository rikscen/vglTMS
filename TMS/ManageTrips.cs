using Framework;
using System;
using System.Data;
using System.Windows.Forms;
using TMS.Utilities;

namespace TMS
{
    public partial class ManageTrips : Form
    {
        public String trip_id = "";

        public ManageTrips()
        {
            InitializeComponent();
        }

        private void ManageTrips_Load(object sender, EventArgs e)
        {
            UISetter.SetGridAppearance(header_grid);
            foreach (DataRow row in DataSupport.RunDataSet($"SELECT * FROM Trips WHERE trip_id = '{ trip_id }'; ").Tables[0].Rows)
            {
                txtTrip.Text = row["trip_id"].ToString();
                txtVehicle.Text = row["vehicle"].ToString();
                txtTripStart.Text = Convert.ToDateTime(row["expected_start"].ToString()).ToShortDateString();
                txtTripEnd.Text = Convert.ToDateTime(row["expected_end"].ToString()).ToShortDateString();
                txtRoute.Text = row["route"].ToString();
                txtLastUpdatedOn.Text = row["last_updated_on"].ToString();
            }
            LoadTable();
        }

        private void LoadTable()
        {
            header_grid.DataSource = DataSupport.RunDataSet($"SELECT order_id, drop_sequence FROM TripOrders WHERE trip ='{ trip_id }' ").Tables[0];
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (var dialog = new AddOrdertoTrip())
            {
                dialog.trip_id = trip_id;
                dialog.ShowDialog();
                LoadTable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var row = header_grid.SelectedRows[0];
            String order_id = row.Cells["order_id"].Value.ToString();
            String trip_id = txtTrip.Text;
            var tripDetailsDT = Utils.GetTripDetails(trip_id);
            // Update itself
            {
                String sql = "DELETE FROM TripOrders WHERE order_id='" + order_id + "' AND trip='" + txtTrip.Text + "'; ";
                DataSupport.RunNonQuery(sql, IsolationLevel.ReadCommitted);
            }
            // Update OMS
            {
                String sql = " UPDATE OutgoingShipmentRequests SET status ='FOR SCHEDULING' WHERE out_shipment_id = '" + order_id + "'; ";
                Connection.GetOMSConnection.ExecuteNonQuery(sql, IsolationLevel.ReadCommitted);
            }

            //Update WMS
            {
                // Sync the trip
                string sql = Utils.GetTripWMSSyncSQL(trip_id);

                // Sync the orders of the trip
                foreach (DataRow trip_row in tripDetailsDT.Rows)
                    sql += $"UPDATE ReleaseOrders SET status = 'FOR SCHEDULING' WHERE order_id = '{ trip_row["order_id"] }';";

                Connection.GetWMSConnection.ExecuteNonQuery(sql, IsolationLevel.ReadCommitted);
            }

            LoadTable();
        }
    }
}