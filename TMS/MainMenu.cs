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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            //Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        private void OpenChildForm(Form form)
        {
            form.MdiParent = this;

            if (Application.OpenForms[form.Name] == null)
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
            else
            {
                Application.OpenForms[form.Name].Activate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TripCalendarWindow dialog = new TripCalendarWindow();
            dialog.ShowDialog();
        }

        private void btnTripUpdate_Click(object sender, EventArgs e)
        {
            UpdateTripsWindow dialog = new UpdateTripsWindow();
            dialog.ShowDialog();
        }

        private void tripCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TripCalendarWindow());
        }

        private void tripUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateTripsWindow());
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.F12)
            {
                using (var dialog = new ConnectionSettings())
                {
                    dialog.ShowDialog();
                }
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            DashboardForm dash = new DashboardForm();
            dash.MdiParent = this;
            dash.Dock = DockStyle.Fill;
            dash.Show();
        }

        private void routePlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var route = new RoutePlanForm())
            {
                route.ShowDialog();
            }
        }

        private void customerRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerRouteForm());
        }
    }
}