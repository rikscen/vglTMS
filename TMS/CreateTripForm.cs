using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TMS.Utilities;
using TMS.DataUnit;
using TMS.DataManager;
using Framework;

namespace TMS
{
    public partial class CreateTripForm : Form
    {
        private int page;

        public CreateTripForm()
        {
            InitializeComponent();
            Size = new Size(377, 358);
        }

        private void CreateTripForm_Load(object sender, EventArgs e)
        {
            UISetter.SetLabelAppearance(label3, label6, label9);
            UISetter.SetButtonAppearance(btnBack, btnNav);
            dtStart.Value = DateTime.Now.AddDays(1);
            dtEnd.Value = DateTime.Now.AddDays(1);
            //grd.SetGridAppearance();
        }

        private void btnNav_Click(object sender, EventArgs e)
        {
            if (pSchedule.Visible && !pVehicle.Visible && !pOverview.Visible)
            {
                if (dtStart.Value.Date > dtEnd.Value.Date)
                {
                    MessageBox.Show("End Date can't be lower than Start Date");
                }
                else
                {
                    var param = new Dictionary<string, object>();
                    param.Add("@start", dtStart.Value);
                    param.Add("@end", dtEnd.Value);
                    //grd.DataSource = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_AvailableVehicle", param);
                    //grd.ClearSelection();
                    lb.DataSource = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_AvailableVehicle", param);
                    lb.DisplayMember = "Vehicle";
                    lb.ValueMember = "Vehicle";
                    pSchedule.Visible = false;
                    pVehicle.Visible = true;
                    btnBack.Visible = true;
                }
            }
            else if (!pSchedule.Visible && pVehicle.Visible && !pOverview.Visible) // Available Vehicle
            {
                //if (grd.SelectedRows.Count == 0)
                //{
                //    MessageBox.Show("Select a vehicle.");
                //}

                lblExpStart.Text = dtStart.Value.Date.ToShortDateString();
                lblExpEnd.Text = dtEnd.Value.Date.ToShortDateString();
                lblIncharge.Text = txtIncharge.Text;
                lblVehicle.Text = lb.SelectedValue.ToString();
                pVehicle.Visible = false;
                pOverview.Visible = true;
                btnNav.Text = "Save";
            }
            else if (!pSchedule.Visible && !pVehicle.Visible && pOverview.Visible)
            {
                var unit = new TripUnit();
                var manager = new TripManager();

                unit.TripId = DataSupport.GetNextMenuCodeInt("TR");
                unit.ExpectedStart = lblExpStart.Text;
                unit.ExpectedEnd = lblExpEnd.Text;
                unit.Incharge = lblIncharge.Text;
                unit.VehicleId = lblVehicle.Text;
                unit.RouteId = "";
                unit.ActualStart = "";
                unit.ActualEnd = "";
                unit.Cost = "";
                unit.LastUpdated = "";

                manager.InsertTrip(unit);
                manager.RunScript();
                MessageBox.Show("Successfully saved!");
                DialogResult = DialogResult.OK;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!pSchedule.Visible && pVehicle.Visible && !pOverview.Visible)
            {
                pVehicle.Visible = false;
                pSchedule.Visible = true;
                btnBack.Visible = false;
            }
            else if (!pSchedule.Visible && !pVehicle.Visible && pOverview.Visible)
            {
                pOverview.Visible = false;
                pVehicle.Visible = true;
                btnNav.Text = "Next >>";
            }
        }

        private void VisibleChange(object sender, EventArgs e)
        {
        }
    }
}