namespace TMS
{
    partial class CreateTripForm
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
            this.btnNav = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pSchedule = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIncharge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pVehicle = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pOverview = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIncharge = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblExpEnd = new System.Windows.Forms.Label();
            this.lblExpStart = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pSchedule.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pVehicle.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pOverview.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNav
            // 
            this.btnNav.Location = new System.Drawing.Point(247, 3);
            this.btnNav.Name = "btnNav";
            this.btnNav.Size = new System.Drawing.Size(112, 43);
            this.btnNav.TabIndex = 5;
            this.btnNav.Text = "Next >>";
            this.btnNav.UseVisualStyleBackColor = true;
            this.btnNav.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(147, 42);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(167, 30);
            this.dtEnd.TabIndex = 2;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(147, 4);
            this.dtStart.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(167, 30);
            this.dtStart.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expected End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expected Start";
            // 
            // pSchedule
            // 
            this.pSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSchedule.Controls.Add(this.panel3);
            this.pSchedule.Controls.Add(this.label3);
            this.pSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSchedule.Location = new System.Drawing.Point(0, 0);
            this.pSchedule.Name = "pSchedule";
            this.pSchedule.Size = new System.Drawing.Size(360, 260);
            this.pSchedule.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtIncharge);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dtEnd);
            this.panel3.Controls.Add(this.dtStart);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 234);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "In-charge";
            // 
            // txtIncharge
            // 
            this.txtIncharge.Location = new System.Drawing.Point(147, 79);
            this.txtIncharge.Name = "txtIncharge";
            this.txtIncharge.Size = new System.Drawing.Size(201, 30);
            this.txtIncharge.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trip Schedule";
            // 
            // pVehicle
            // 
            this.pVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pVehicle.Controls.Add(this.panel4);
            this.pVehicle.Controls.Add(this.label6);
            this.pVehicle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pVehicle.Location = new System.Drawing.Point(360, 0);
            this.pVehicle.Name = "pVehicle";
            this.pVehicle.Size = new System.Drawing.Size(360, 260);
            this.pVehicle.TabIndex = 6;
            this.pVehicle.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lb);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 234);
            this.panel4.TabIndex = 5;
            // 
            // lb
            // 
            this.lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 33;
            this.lb.Location = new System.Drawing.Point(0, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(358, 234);
            this.lb.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Available vehicle for this schedule";
            // 
            // pOverview
            // 
            this.pOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pOverview.Controls.Add(this.panel2);
            this.pOverview.Controls.Add(this.label9);
            this.pOverview.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOverview.Location = new System.Drawing.Point(720, 0);
            this.pOverview.Name = "pOverview";
            this.pOverview.Size = new System.Drawing.Size(360, 260);
            this.pOverview.TabIndex = 6;
            this.pOverview.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblIncharge);
            this.panel2.Controls.Add(this.lblVehicle);
            this.panel2.Controls.Add(this.lblExpEnd);
            this.panel2.Controls.Add(this.lblExpStart);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 234);
            this.panel2.TabIndex = 5;
            // 
            // lblIncharge
            // 
            this.lblIncharge.BackColor = System.Drawing.Color.White;
            this.lblIncharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIncharge.Location = new System.Drawing.Point(147, 114);
            this.lblIncharge.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIncharge.Name = "lblIncharge";
            this.lblIncharge.Size = new System.Drawing.Size(171, 30);
            this.lblIncharge.TabIndex = 6;
            this.lblIncharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVehicle
            // 
            this.lblVehicle.BackColor = System.Drawing.Color.White;
            this.lblVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicle.Location = new System.Drawing.Point(147, 78);
            this.lblVehicle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(171, 30);
            this.lblVehicle.TabIndex = 6;
            this.lblVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExpEnd
            // 
            this.lblExpEnd.BackColor = System.Drawing.Color.White;
            this.lblExpEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExpEnd.Location = new System.Drawing.Point(147, 42);
            this.lblExpEnd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblExpEnd.Name = "lblExpEnd";
            this.lblExpEnd.Size = new System.Drawing.Size(171, 30);
            this.lblExpEnd.TabIndex = 6;
            this.lblExpEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExpStart
            // 
            this.lblExpStart.BackColor = System.Drawing.Color.White;
            this.lblExpStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExpStart.Location = new System.Drawing.Point(147, 6);
            this.lblExpStart.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblExpStart.Name = "lblExpStart";
            this.lblExpStart.Size = new System.Drawing.Size(171, 30);
            this.lblExpStart.TabIndex = 6;
            this.lblExpStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 117);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "In-charge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vehicle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Expected Start";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Expected End";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(358, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Trip Overview";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(129, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 43);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnNav);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 49);
            this.panel1.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pOverview);
            this.panel5.Controls.Add(this.pVehicle);
            this.panel5.Controls.Add(this.pSchedule);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1083, 260);
            this.panel5.TabIndex = 9;
            // 
            // CreateTripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 319);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateTripForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Trip";
            this.Load += new System.EventHandler(this.CreateTripForm_Load);
            this.pSchedule.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pVehicle.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pOverview.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNav;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pSchedule;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIncharge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pVehicle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pOverview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIncharge;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblExpEnd;
        private System.Windows.Forms.Label lblExpStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox lb;
    }
}