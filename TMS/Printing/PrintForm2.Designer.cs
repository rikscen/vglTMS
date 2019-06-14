namespace TMS.Printing
{
    partial class PrintForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // viewer
            // 
            this.viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewer.LocalReport.ReportEmbeddedResource = "";
            this.viewer.Location = new System.Drawing.Point(0, 0);
            this.viewer.Name = "viewer";
            this.viewer.ServerReport.BearerToken = null;
            this.viewer.Size = new System.Drawing.Size(800, 450);
            this.viewer.TabIndex = 0;
            // 
            // PrintForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewer);
            this.Name = "PrintForm2";
            this.Text = "PrintForm2";
            this.Load += new System.EventHandler(this.PrintForm2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer viewer;
    }
}