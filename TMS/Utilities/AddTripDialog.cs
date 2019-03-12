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

namespace TMS.Utilities
{
    public partial class AddTripDialog : Form
    {
        public AddTripDialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void AddTripDialog_Load(object sender, EventArgs e)
        {
            UISetter.SetButtonAppearance(btnAdd);
            txtStart.Value = DateTime.Now.AddDays(1);
            txtEnd.Value = DateTime.Now.AddDays(1);

            var dt = DataSupport.RunDataSet("SELECT * FROM Vehicles").Tables[0];
            foreach (DataRow row in dt.Rows)
                txtVehicle.Items.Add(row["vehicle_id"]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            if (FAQ.IsDatesBlocked(txtVehicle.Text, DateTime.Parse(txtStart.Value.ToShortDateString()), DateTime.Parse(txtEnd.Value.ToShortDateString()), ref message))
            {
                MessageBox.Show(message);
                return;
            }
            if (txtStart.Value > txtEnd.Value)
            {
                MessageBox.Show("End Date can't be lower than Start Date");
                return;
            }

            String trip_id = DataSupport.GetNextMenuCodeInt("TR");

            Dictionary<String, Object> dict = new Dictionary<string, object>();
            dict.Add("trip_id", trip_id);
            dict.Add("vehicle", txtVehicle.Text);
            dict.Add("in_charge", txtInCharge.Text);
            dict.Add("expected_start", txtStart.Value.ToShortDateString());
            dict.Add("expected_end", txtEnd.Value.ToShortDateString());

            String sql = DataSupport.GetInsert("Trips", dict);

            DataSupport.RunNonQuery(sql, IsolationLevel.ReadCommitted);

            MessageBox.Show("Success");
            DialogResult = DialogResult.OK;
        }
    }
}