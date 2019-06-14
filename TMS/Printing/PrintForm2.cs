using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.Printing
{
    public partial class PrintForm2 : Form
    {
        public List<ReportDataSource> ReportDataSources { get; set; }

        public PrintForm2(List<ReportDataSource> reports)
        {
            InitializeComponent();
            ReportDataSources = reports;
        }

        private void PrintForm2_Load(object sender, EventArgs e)
        {
            foreach (ReportDataSource report in ReportDataSources)
            {
                viewer.LocalReport.DataSources.Add(report);
            }
            
            this.viewer.RefreshReport();
        }
    }
}