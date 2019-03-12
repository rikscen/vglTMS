using Framework;
using System;
using System.Data;
using System.Windows.Forms;
using TMS.Utilities;

namespace TMS
{
    public partial class UpdateTripsWindow : Form
    {
        public UpdateTripsWindow()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            String trip_id = txtTripID.Text.Replace("'", "");
            DataTable dt = DataSupport.RunDataSet(@"SELECT order_id[ORDER ID], client[CLIENT], customer[CUSTOMER], STATUS
                                                    FROM TripOrders
                                                    WHERE trip = '" + trip_id + "'; ").Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var new_row = header_grid.Rows[header_grid.Rows.Add()];

                new_row.Cells[0].Value = row["ORDER ID"];
                new_row.Cells[1].Value = row["CLIENT"];
                new_row.Cells[2].Value = row["CUSTOMER"];

                // Don't put status unless it's in the master file
                String status = row["STATUS"].ToString();
                if (this.status.Items.Contains(status))
                    new_row.Cells[2].Value = status;
            }
        }

        private void UpdateTripsWindow_Load(object sender, EventArgs e)
        {
            UISetter.SetButtonAppearance(btnLoad, btnUpdate);
            UISetter.SetGridAppearance(header_grid);
            DataTable dt = DataSupport.RunDataSet("SELECT * FROM OrderDeliveryStatuses").Tables[0];
            foreach (DataRow row in dt.Rows)
                status.Items.Add(row["status"].ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }
    }
}