using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TMS.DataUnit;
using TMS.Utilities;

namespace TMS.User_Controls
{
    public partial class TripOverviewUserControl : UserControl
    {
        private TripUnit Unit { get; set; }

        public TripOverviewUserControl(TripUnit unit)
        {
            InitializeComponent();
            Unit = unit;
        }

        private void TripOverviewUserControl_Load(object sender, EventArgs e)
        {
            lblTripNo.Text = Unit.TripId;
            lblVehicle.Text = Unit.VehicleId;
            lblTripStart.Text = Unit.ExpectedStart;
            lblTripEnd.Text = Unit.ExpectedEnd;
            lblIncharge.Text = Unit.Incharge;
            cbRoute.SelectedValue = Unit.RouteId;
            lblLastUpdated.Text = Unit.LastUpdated;
            UISetter.SetButtonAppearance(btnNav);
            UISetter.SetLabelAppearance(lblTripOverview, lblOrder);
            grdOrders.SetGridAppearance();
            LoadOrders();
            grdOrders.ClearSelection();
        }

        private void LoadOrders()
        {
            grdOrders.Rows.Clear();

            var param = new Dictionary<string, object>();
            param.Add("@trip_id", lblTripNo.Text);

            int dropSequence = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetTripOrders", param).Rows.Count;
            grdOrders.DataSource = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetTripOrders", param);
        }
    }
}