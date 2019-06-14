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
        Dictionary<String, DataRow> vehl = new Dictionary<string, DataRow>();
        public DashboardForm()
        {
            InitializeComponent();
            grdTrip.CellContentClick += grdTrip_CellContentClick;
            rbAllTrips.CheckedChanged += rbAllTrips_CheckedChanged;
            rbWithOrders.CheckedChanged += rbWithOrders_CheckedChanged;
            rbWithNoOrders.CheckedChanged += rbWithNoOrders_CheckedChanged;
            tc.Selected += tc_Selected;
            grd.CellValueChanged += Grd_CellValueChanged;
            grd.CellMouseUp += Grd_CellMouseUp;
        }

        private void Grd_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == grd.Columns["Checkbox"].Index && e.RowIndex != -1)
            {
                grd.EndEdit();
            }
        }

        private void Grd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grd.Columns["Checkbox"].Index && e.RowIndex != -1)
            {
                // Handle checkbox state change here
                if ((bool)grd.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue)
                {
                    grd.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml(VGLHelper.Etcetera.SECONDARY_COLOR);
                    grd.Rows[e.RowIndex].DefaultCellStyle.ForeColor = ColorTranslator.FromHtml(VGLHelper.Etcetera.ACCENT);
                }
                else
                {
                    grd.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    grd.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
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

        private void InitializeGrid()
        {
            #region Orders

            {
                var col9 = new DataGridViewCheckBoxColumn();
                col9.Name = "Checkbox";
                col9.HeaderText = "";
                col9.TrueValue = 1;
                col9.FalseValue = 0;
                col9.FillWeight = 50;
                grd.Columns.Add(col9);

                var col1 = new DataGridViewTextBoxColumn();
                col1.Name = "Outshipment Id";
                col1.HeaderText = "Outshipment Id";
                col1.DataPropertyName = "out_shipment_id";
                col1.ReadOnly = true;
                col1.FillWeight = 150;
                //grd.Columns.Add(col1);

                var col2 = new DataGridViewTextBoxColumn();
                col2.Name = "Ref Doc Date";
                col2.HeaderText = "REF Doc Date";
                col2.DataPropertyName = "Ref Doc Date";
                col2.ReadOnly = true;
                col2.FillWeight = 100;
                //grd.Columns.Add(col2);

                var col3 = new DataGridViewTextBoxColumn();
                col3.Name = "Ref Doc";
                col3.HeaderText = "REF Doc";
                col3.DataPropertyName = "Ref Doc";
                col3.ReadOnly = true;
                //grd.Columns.Add(col3);

                var col4 = new DataGridViewTextBoxColumn();
                col4.Name = "Client";
                col4.HeaderText = "Client";
                col4.DataPropertyName = "client";
                col4.ReadOnly = true;
                //grd.Columns.Add(col4);

                var col5 = new DataGridViewTextBoxColumn();
                col5.Name = "Customer Id";
                col5.HeaderText = "Customer";
                col5.DataPropertyName = "customer_id";
                col5.ReadOnly = true;
                //grd.Columns.Add(col5);

                var col6 = new DataGridViewTextBoxColumn();
                col6.Name = "Customer Name";
                col6.HeaderText = "Customer Name";
                col6.DataPropertyName = "name";
                col6.ReadOnly = true;
                col6.FillWeight = 300;
                //grd.Columns.Add(col6);

                var col7 = new DataGridViewTextBoxColumn();
                col7.Name = "Route";
                col7.HeaderText = "Route";
                col7.DataPropertyName = "route";
                col7.ReadOnly = true;
                col7.FillWeight = 50;

                var col8 = new DataGridViewTextBoxColumn();
                col8.Name = "Document Value";
                col8.HeaderText = "Document Value";
                col8.DataPropertyName = "doc value";
                col8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col8.ReadOnly = true;

                grd.Columns.AddRange(col1, col2, col3, col4, col5, col6, col7, col8);
                grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            #endregion Orders

            #region Trip

            {
                grdTrip.Columns.AddRange(new DataGridViewButtonColumn
                {
                    Name = "Action",
                    HeaderText = "Action",
                    Text = "View",
                    UseColumnTextForButtonValue = true,
                    FillWeight = 100
                }, new DataGridViewTextBoxColumn
                {
                    Name = "Trip Id",
                    HeaderText = "Trip No",
                    DataPropertyName = "trip_id",
                    ReadOnly = true,
                    FillWeight = 100
                }, new DataGridViewTextBoxColumn
                {
                    Name = "Vehicle",
                    HeaderText = "Vehicle",
                    DataPropertyName = "vehicle",
                    ReadOnly = true,
                    FillWeight = 100,
                }, new DataGridViewTextBoxColumn
                {
                    Name = "Expected Start",
                    HeaderText = "Expected Start",
                    DataPropertyName = "expected_start",
                    ReadOnly = true,
                    FillWeight = 100
                }, new DataGridViewTextBoxColumn
                {
                    Name = "Expected End",
                    HeaderText = "Expected End",
                    DataPropertyName = "expected_end",
                    ReadOnly = true,
                    FillWeight = 100
                }, new DataGridViewTextBoxColumn
                {
                    Name = "In charge",
                    HeaderText = "In-charge",
                    DataPropertyName = "in_charge",
                    ReadOnly = true,
                    FillWeight = 100
                }, new DataGridViewTextBoxColumn
                {
                    Name = "Route",
                    HeaderText = "Route",
                    DataPropertyName = "route",
                    ReadOnly = true,
                    FillWeight = 100
                }, new DataGridViewTextBoxColumn
                {
                    Name = "Last Updated",
                    HeaderText = "Last Updated on",
                    DataPropertyName = "last_updated_on",
                    Visible = false,
                    FillWeight = 100
                }, new DataGridViewTextBoxColumn
                {
                    Name = "Driver",
                    HeaderText = "Driver",
                    DataPropertyName = "Driver",
                    Visible = true,
                    FillWeight = 100
                }, new DataGridViewTextBoxColumn
                {
                    Name = "Helper 1",
                    HeaderText = "Helper 1",
                    DataPropertyName = "helper1",
                    Visible = true,
                    FillWeight = 100
                }, new DataGridViewTextBoxColumn
                {
                    Name = "Helper 2",
                    HeaderText = "Helper 2",
                    DataPropertyName = "helper2",
                    Visible = true,
                    FillWeight = 100
                }, new DataGridViewTextBoxColumn
                {
                    Name = "Helper 3",
                    HeaderText = "Helper 3",
                    DataPropertyName = "helper3",
                    Visible = true,
                    FillWeight = 100
                });
            }

            #endregion Trip
        }

        private void LoadOrder()
        {
            grd.DataSource = DataManager.TripManager.GetOrders();
            lblOrders.Visible = grd.RowCount == 0;
        }

        private void LoadTrips(int flag)
        {
            string message;
            grdTrip.DataSource = DataManager.TripManager.GetTrips(flag, out message);
            lblTripMessage.Visible = grdTrip.RowCount == 0;
            lblTripMessage.Text = message;
            vehl = Utils.BuildIndex("SELECT * FROM vehicles", "vehicle_id");
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
            UISetter.SetGridAppearance(grd, grdTrip, grdVehicle);
            InitializeGrid();
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

            //grd.EndEdit(DataGridViewDataErrorContexts.Commit);
            //if (grd.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("No orders selected. Please select orders.");
            //    return;
            //}

            //foreach (DataGridViewRow row in grd.SelectedRows)
            //{
            //    sb.AppendFormat(",'{0}'", row.Cells["colShipId"].Value.ToString());
            //}

            //for (int i = grd.SelectedRows.Count - 1; i >= 0; i--)
            //{
            //    //sb.AppendFormat(",'{0}'", grd.SelectedRows[i].Cells["colShipId"].Value.ToString());

            //    param.Add("@id", grd.SelectedRows[i].Cells["OutShipment Id"].Value.ToString());
            //    param.Add("@flag", true);

            //    dt.ImportRow(Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetOutShipmentForScheduling", param).Rows[0]);
            //    param.Clear();
            //}

            for (int i = 0; i <= grd.Rows.Count - 1; i++)
            {
                //sb.AppendFormat(",'{0}'", grd.SelectedRows[i].Cells["colShipId"].Value.ToString());
                if (!(bool)grd.Rows[i].Cells["Checkbox"].FormattedValue)
                    continue;

                param.Add("@id", grd.Rows[i].Cells["OutShipment Id"].Value.ToString());
                param.Add("@flag", true);

                dt.ImportRow(Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetOutShipmentForScheduling", param).Rows[0]);
                param.Clear();
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No orders selected. Please select orders.");
                return;
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
            grdTrip.ClearSelection();
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

        private void grdTrip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grd = sender as DataGridView;
            if (grd.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var unit = new TripUnit();
                unit.TripId = grd.Rows[e.RowIndex].Cells["Trip Id"].Value.ToString();
                unit.VehicleId = grd.Rows[e.RowIndex].Cells["Vehicle"].Value.ToString();
                unit.plateno = vehl[unit.VehicleId]["plate_no"].ToString();
                unit.ExpectedStart = DateTime.Parse(grd.Rows[e.RowIndex].Cells["Expected Start"].Value.ToString()).ToShortDateString();
                unit.ExpectedEnd = DateTime.Parse(grd.Rows[e.RowIndex].Cells["Expected End"].Value.ToString()).ToShortDateString();
                unit.Incharge = grd.Rows[e.RowIndex].Cells["In charge"].Value.ToString();
                unit.RouteId = grd.Rows[e.RowIndex].Cells["Route"].Value.ToString();
                unit.LastUpdated = grd.Rows[e.RowIndex].Cells["Last Updated"].Value.ToString();
                unit.Driver = grd.Rows[e.RowIndex].Cells["Driver"].Value.ToString();
                unit.Helper1 = grd.Rows[e.RowIndex].Cells["Helper 1"].Value.ToString();
                unit.Helper2 = grd.Rows[e.RowIndex].Cells["Helper 2"].Value.ToString();
                unit.Helper3 = grd.Rows[e.RowIndex].Cells["Helper 3"].Value.ToString();
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