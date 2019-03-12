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
    public partial class ViewOrdersForm : Form
    {
        public ViewOrdersForm()
        {
            InitializeComponent();
        }

        private void ViewOrdersForm_Load(object sender, EventArgs e)
        {
            UISetter.SetLabelAppearance(label2);
            grd.SetGridAppearance();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            var param = new Dictionary<string, object>();
            var dt = Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetOutShipmentForScheduling", null).Clone();

            if (grd.SelectedRows.Count == 0)
            {
                MessageBox.Show("No orders selected. Please select orders.");
                return;
            }

            //foreach (DataGridViewRow row in grd.SelectedRows)
            //{
            //    sb.AppendFormat(",'{0}'", row.Cells["colShipId"].Value.ToString());
            //}

            for (int i = grd.SelectedRows.Count - 1; i >= 0; i--)
            {
                //sb.AppendFormat(",'{0}'", grd.SelectedRows[i].Cells["colShipId"].Value.ToString());
                param.Add("@id", grd.SelectedRows[i].Cells["colShipId"].Value.ToString());
                param.Add("@flag", true);

                dt.ImportRow(Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetOutShipmentForScheduling", param).Rows[0]);
                param.Clear();
            }
            //sb.Remove(0, 1);
        }
    }
}