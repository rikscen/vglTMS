namespace TMS
{
    partial class RoutePlanForm
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
            this.grd = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 50);
            this.grd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd.Name = "grd";
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grd.Size = new System.Drawing.Size(1150, 551);
            this.grd.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEnd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtStart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 50);
            this.panel1.TabIndex = 1;
            // 
            // txtEnd
            // 
            this.txtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEnd.Location = new System.Drawing.Point(221, 13);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(107, 25);
            this.txtEnd.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "End";
            // 
            // txtStart
            // 
            this.txtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStart.Location = new System.Drawing.Point(52, 13);
            this.txtStart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(107, 25);
            this.txtStart.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 601);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 55);
            this.panel2.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1015, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // RoutePlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 656);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RoutePlanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Route Plan";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
    }
}