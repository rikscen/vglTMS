using Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TMS.Utilities;

namespace TMS
{
    public partial class TripCalendarWindow : Form
    {
        public TripCalendarWindow()
        {
            InitializeComponent();
        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            using (var dialog = new AddTripDialog())
            {
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                {
                    LoadTrips();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadTrips();
        }

        private void LoadTrips()
        {
            DateTime start = DateTime.Parse(txtStart.Value.ToShortDateString());
            DateTime end = DateTime.Parse(txtEnd.Value.ToShortDateString());
            FillCommonData();

            var trip_dt = DataSupport.RunDataSet("SELECT * FROM Trips WHERE expected_start >= '" + start + "' AND expected_end >='" + start + "'").Tables[0];

            for (int i = 1; i < header_grid.Columns.Count; i++)
            {
                var col = header_grid.Columns[i];

                foreach (DataGridViewRow row in header_grid.Rows)
                {
                    var vehicle = row.Cells[0].Value.ToString();
                    var date = DateTime.Parse(col.Name);

                    foreach (DataRow trip_row in trip_dt.Rows)
                        if (vehicle == trip_row["vehicle"].ToString() && date >= DateTime.Parse(trip_row["expected_start"].ToString()) && date <= DateTime.Parse(trip_row["expected_end"].ToString()))
                            row.Cells[col.Name].Value = trip_row["trip_id"];
                }
            }
        }

        private void FillCommonData()
        {
            DateTime start = DateTime.Parse(txtStart.Value.ToShortDateString());
            DateTime end = DateTime.Parse(txtEnd.Value.ToShortDateString());

            // Clear grids

            header_grid.Columns.Clear();
            header_grid.Rows.Clear();

            // Draw columns
            header_grid.Columns.Add("Vehicle", "Vehicle");

            for (DateTime i = txtStart.Value; i <= end; i = i.AddDays(1))
                header_grid.Columns.Add(i.ToShortDateString(), i.ToShortDateString());

            // Draw rows for vehicles
            var vehicle_dt = DataSupport.RunDataSet("SELECT vehicle_id FROM Vehicles").Tables[0];

            foreach (DataRow row in vehicle_dt.Rows)
                header_grid.Rows.Add(row[0].ToString());

            // Draw Blocking

            var blocking_dt = DataSupport.RunDataSet("SELECT vehicle, date, name FROM VehicleBlocking").Tables[0];

            for (int i = 1; i < header_grid.Columns.Count; i++)
            {
                var col = header_grid.Columns[i];

                foreach (DataGridViewRow row in header_grid.Rows)
                {
                    var vehicle = row.Cells[0].Value.ToString();
                    var date = DateTime.Parse(col.Name);

                    foreach (DataRow blocking_row in blocking_dt.Rows)
                    {
                        if (blocking_row["vehicle"].ToString() == "TRUCK C"
                            && vehicle == "TRUCK C"

                            )
                        {
                        }

                        if ((vehicle == blocking_row["vehicle"].ToString() || blocking_row["vehicle"].ToString() == "ALL") && DateTime.Parse(blocking_row["date"].ToString()) == date)
                            row.Cells[col.Name].Value = blocking_row["name"];
                    }
                }
            }
        }

        private void TripCalendarWindow_Load(object sender, EventArgs e)
        {
            UISetter.SetButtonAppearance(btnTrip, btnSearch, btnManageTrip, btnChangeRoute, btnRoute, btnDrop);
            UISetter.SetGridAppearance(header_grid);
            txtEnd.Value = DateTime.Now.AddDays(14);

            var dt = DataSupport.RunDataSet("SELECT route_id FROM Routes").Tables[0];
            foreach (DataRow row in dt.Rows)
                cbRoutes.Items.Add(row[0].ToString());
        }

        private void btnChangeRoute_Click(object sender, EventArgs e)
        {
            var cells = header_grid.SelectedCells;
            StringBuilder sql = new StringBuilder();

            foreach (DataGridViewCell cell in cells)
            {
                string vehicle = cell.OwningRow.Cells[0].Value.ToString();
                string date = cell.OwningColumn.Name;
                Dictionary<string, Object> dict = new Dictionary<string, object>();
                dict.Add("date", date);
                dict.Add("vehicle", vehicle);
                dict.Add("route", cbRoutes.Text);

                sql.Append(DataSupport.GetUpsert("RouteSchedules", dict, "date", "vehicle"));
            }

            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("Success");
            LoadRoutes();
        }

        private void LoadRoutes()
        {
            DateTime start = DateTime.Parse(txtStart.Value.ToShortDateString());
            DateTime end = DateTime.Parse(txtEnd.Value.ToShortDateString());

            FillCommonData();

            var route_dt = DataSupport.RunDataSet("SELECT * FROM RouteSchedules WHERE date >= '" + start + "' AND date <='" + end + "' ").Tables[0];

            for (int i = 1; i < header_grid.Columns.Count; i++)
            {
                var col = header_grid.Columns[i];

                foreach (DataGridViewRow row in header_grid.Rows)
                {
                    var vehicle = row.Cells[0].Value.ToString();
                    var date = DateTime.Parse(col.Name);

                    foreach (DataRow route_row in route_dt.Rows)
                        if (vehicle == route_row["vehicle"].ToString() && date == DateTime.Parse(route_row["date"].ToString()))
                            row.Cells[col.Name].Value = route_row["route"].ToString();
                }
            }
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            LoadRoutes();
        }

        private void btnManageTrip_Click(object sender, EventArgs e)
        {
            if (header_grid.RowCount == 0)
            {
                MessageBox.Show("Please click Trips to load lists of trips", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (header_grid.CurrentCell.Value == null)
            {
            }
            else if (header_grid.CurrentCell.ColumnIndex == 0)
            {
            }
            else
            {
                ManageTrips dialog = new ManageTrips();
                dialog.trip_id = header_grid.SelectedCells[0].Value.ToString();
                dialog.ShowDialog();
            }
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
        }

        private void header_grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 && e.RowIndex >= 0)
            {
                if (header_grid.CurrentCell.Value != null)
                {
                    ManageTrips dialog = new ManageTrips();
                    dialog.trip_id = header_grid.SelectedCells[0].Value.ToString();
                    dialog.ShowDialog();
                }
            }
        }
    }
}