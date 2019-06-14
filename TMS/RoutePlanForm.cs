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

namespace TMS
{
    public partial class RoutePlanForm : Form
    {
        private List<RouteUnit> Routes { get; set; }

        public RoutePlanForm()
        {
            InitializeComponent();
            Load += RoutePlanForm_Load;
            UISetter.SetGridAppearance(grd);
            UISetter.SetButtonAppearance(btnSave);
            grd.MouseDoubleClick += Grd_MouseDoubleClick;
            grd.EditingControlShowing += Grd_EditingControlShowing;
            grd.CellEndEdit += Grd_CellEndEdit;
            btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var manager = new RouteManager();
            List<IUnit> routes = new List<IUnit>();
            for (int r = 0; r <= grd.RowCount - 1; r++)
            {
                for (int c = 0; c < grd.ColumnCount - 1; c++)
                {
                    if (grd.Rows[r].Cells[c].Value is null || string.IsNullOrWhiteSpace(grd.Rows[r].Cells[c].Value.ToString()))
                        continue;

                    routes.Add(new RouteScheduleUnit
                    {
                        RouteId = grd.Rows[r].Cells[c].Value.ToString(),
                        RouteDate = $"{grd.Columns[c].Name}/{txtEnd.Value.Year} ",
                        VehicleId = grd.Rows[r].HeaderCell.Value.ToString()
                    });
                }
            }

            manager.Insert(routes, RouteManager.InsertType.RouteSchedule);
            manager.RunScript();
            MessageBox.Show("Saved");
        }

        private void Grd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (grd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value is null)
                return;

            if (!RouteManager.FindRoute(grd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                MessageBox.Show("Route not found.\nPlease try again");
                grd.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "No route found";
            }
            else
            {
                grd.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "";
                grd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = grd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper();
            }
        }

        private void Grd_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (e.Control is DataGridViewTextBoxEditingControl)
            //{
            //    var tb = e.Control as TextBox;

            //    tb.AutoCompleteMode = AutoCompleteMode.Suggest;
            //    tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //    tb.AutoCompleteCustomSource = new AutoCompleteStringCollection { "AA", "BB", "CC" };
            //}
        }

        private void Grd_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var pointer = grd.HitTest(e.X, e.Y);
                if (pointer.Type == DataGridViewHitTestType.Cell)
                {
                    if (grd.Columns[pointer.ColumnIndex].HeaderText.Contains("Sunday"))
                    {
                        MessageBox.Show("Test");
                    }
                }
            }
        }

        private void Grd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void RoutePlanForm_Load(object sender, EventArgs e)
        {
            txtEnd.Value = txtEnd.Value.AddDays(14);
            LoadTrips();
        }

        private void LoadTrips()
        {
            var start = DateTime.Parse(txtStart.Value.ToShortDateString());
            var end = DateTime.Parse(txtEnd.Value.ToShortDateString());
            var param = new Dictionary<string, object>();
            for (var i = start; i <= end; i = i.AddDays(1))
            {
                grd.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = $"{i.Month}/{i.Day}",
                    HeaderText = $"{ i.Month }/{i.Day}\n{i.DayOfWeek}",
                    Width = 150,
                    DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter },
                    //ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                });
            }

            grd.RowCount = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetVehicles", null).Rows.Count;

            int rowIndex = 0;
            foreach (DataRow row in Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetVehicles", null).Rows)
            {
                grd.Rows[rowIndex].HeaderCell.Value = row["vehicle_id"];
                int colIndex = 0;
                foreach (DataRow row2 in GetRouteSchedule(row["vehicle_id"].ToString(), start, end))
                {
                    grd.Rows[rowIndex].Cells[colIndex].Value = row2["route"];
                    colIndex++;
                }
                rowIndex++;
            }
        }

        private DataRowCollection GetRouteSchedule(string vehicle, DateTime start, DateTime end)
        {
            var param = new Dictionary<string, object>
            {
                { "@vehicle", vehicle },
                { "@start", start },
                { "@end", end }
            };
            return Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetRouteSchedules", param).Rows;
        }
    }
}