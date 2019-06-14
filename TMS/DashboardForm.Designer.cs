namespace TMS
{
    partial class DashboardForm
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tc = new VGLHelper.CustomControls.vglTabControl();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.lblOrders = new System.Windows.Forms.Label();
            this.grd = new VGLHelper.CustomControls.vglDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tpSchedule = new System.Windows.Forms.TabPage();
            this.lblTripMessage = new System.Windows.Forms.Label();
            this.grdTrip = new VGLHelper.CustomControls.vglDataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCreateTrip = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbWithNoOrders = new System.Windows.Forms.RadioButton();
            this.rbWithOrders = new System.Windows.Forms.RadioButton();
            this.rbAllTrips = new System.Windows.Forms.RadioButton();
            this.lblSchedules = new System.Windows.Forms.Label();
            this.tpVehicles = new System.Windows.Forms.TabPage();
            this.grdVehicle = new System.Windows.Forms.DataGridView();
            this.colVehicleCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tc.SuspendLayout();
            this.tpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.panel4.SuspendLayout();
            this.tpSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrip)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tpVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicle)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.AllowDrop = true;
            this.tc.BorderColor = System.Drawing.Color.Empty;
            this.tc.Controls.Add(this.tpOrders);
            this.tc.Controls.Add(this.tpSchedule);
            this.tc.Controls.Add(this.tpVehicles);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.tc.ItemSize = new System.Drawing.Size(180, 50);
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.tc.Size = new System.Drawing.Size(1184, 561);
            this.tc.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc.TabBackColor = System.Drawing.Color.White;
            this.tc.TabIndex = 16;
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.lblOrders);
            this.tpOrders.Controls.Add(this.grd);
            this.tpOrders.Controls.Add(this.label2);
            this.tpOrders.Controls.Add(this.panel4);
            this.tpOrders.Location = new System.Drawing.Point(4, 54);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Size = new System.Drawing.Size(1176, 503);
            this.tpOrders.TabIndex = 0;
            this.tpOrders.Text = "Orders";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // lblOrders
            // 
            this.lblOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(143, 191);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(890, 54);
            this.lblOrders.TabIndex = 51;
            this.lblOrders.Text = "NO ORDERS TO SCHEDULE";
            this.lblOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrders.Visible = false;
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 24);
            this.grd.Name = "grd";
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(1176, 422);
            this.grd.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1176, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Orders for Scheduling";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btnSchedule);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 446);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1176, 57);
            this.panel4.TabIndex = 15;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(960, 8);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(213, 46);
            this.btnSchedule.TabIndex = 50;
            this.btnSchedule.Text = "Schedule Selected Orders";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Note: To select multiple orders; Hold and press CTRL + LEFT CLICK";
            // 
            // tpSchedule
            // 
            this.tpSchedule.BackColor = System.Drawing.Color.White;
            this.tpSchedule.Controls.Add(this.lblTripMessage);
            this.tpSchedule.Controls.Add(this.grdTrip);
            this.tpSchedule.Controls.Add(this.panel3);
            this.tpSchedule.Controls.Add(this.panel5);
            this.tpSchedule.Controls.Add(this.lblSchedules);
            this.tpSchedule.Location = new System.Drawing.Point(4, 54);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Size = new System.Drawing.Size(1176, 503);
            this.tpSchedule.TabIndex = 1;
            this.tpSchedule.Text = "Trip Schedules";
            // 
            // lblTripMessage
            // 
            this.lblTripMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTripMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripMessage.Location = new System.Drawing.Point(143, 181);
            this.lblTripMessage.Name = "lblTripMessage";
            this.lblTripMessage.Size = new System.Drawing.Size(890, 140);
            this.lblTripMessage.TabIndex = 52;
            this.lblTripMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTripMessage.Visible = false;
            // 
            // grdTrip
            // 
            this.grdTrip.AllowUserToAddRows = false;
            this.grdTrip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTrip.Location = new System.Drawing.Point(0, 62);
            this.grdTrip.Name = "grdTrip";
            this.grdTrip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTrip.Size = new System.Drawing.Size(1176, 384);
            this.grdTrip.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCreateTrip);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 446);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1176, 57);
            this.panel3.TabIndex = 8;
            // 
            // btnCreateTrip
            // 
            this.btnCreateTrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTrip.Location = new System.Drawing.Point(1031, 8);
            this.btnCreateTrip.Name = "btnCreateTrip";
            this.btnCreateTrip.Size = new System.Drawing.Size(142, 46);
            this.btnCreateTrip.TabIndex = 5;
            this.btnCreateTrip.Text = "Create Trip";
            this.btnCreateTrip.UseVisualStyleBackColor = true;
            this.btnCreateTrip.Click += new System.EventHandler(this.btnCreateTrip_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbWithNoOrders);
            this.panel5.Controls.Add(this.rbWithOrders);
            this.panel5.Controls.Add(this.rbAllTrips);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1176, 35);
            this.panel5.TabIndex = 6;
            // 
            // rbWithNoOrders
            // 
            this.rbWithNoOrders.AutoSize = true;
            this.rbWithNoOrders.Location = new System.Drawing.Point(178, 8);
            this.rbWithNoOrders.Name = "rbWithNoOrders";
            this.rbWithNoOrders.Size = new System.Drawing.Size(112, 20);
            this.rbWithNoOrders.TabIndex = 2;
            this.rbWithNoOrders.Text = "With no orders";
            this.rbWithNoOrders.UseVisualStyleBackColor = false;
            // 
            // rbWithOrders
            // 
            this.rbWithOrders.AutoSize = true;
            this.rbWithOrders.Location = new System.Drawing.Point(81, 8);
            this.rbWithOrders.Name = "rbWithOrders";
            this.rbWithOrders.Size = new System.Drawing.Size(94, 20);
            this.rbWithOrders.TabIndex = 2;
            this.rbWithOrders.Text = "With orders";
            this.rbWithOrders.UseVisualStyleBackColor = false;
            // 
            // rbAllTrips
            // 
            this.rbAllTrips.AutoSize = true;
            this.rbAllTrips.Checked = true;
            this.rbAllTrips.Location = new System.Drawing.Point(3, 8);
            this.rbAllTrips.Name = "rbAllTrips";
            this.rbAllTrips.Size = new System.Drawing.Size(75, 20);
            this.rbAllTrips.TabIndex = 2;
            this.rbAllTrips.TabStop = true;
            this.rbAllTrips.Text = "All Trips";
            this.rbAllTrips.UseVisualStyleBackColor = false;
            // 
            // lblSchedules
            // 
            this.lblSchedules.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSchedules.Location = new System.Drawing.Point(0, 0);
            this.lblSchedules.Name = "lblSchedules";
            this.lblSchedules.Size = new System.Drawing.Size(1176, 27);
            this.lblSchedules.TabIndex = 3;
            this.lblSchedules.Text = "Ongoing Trip Schedules";
            // 
            // tpVehicles
            // 
            this.tpVehicles.Controls.Add(this.grdVehicle);
            this.tpVehicles.Location = new System.Drawing.Point(4, 54);
            this.tpVehicles.Name = "tpVehicles";
            this.tpVehicles.Size = new System.Drawing.Size(1176, 503);
            this.tpVehicles.TabIndex = 2;
            this.tpVehicles.Text = "Vehicles";
            this.tpVehicles.UseVisualStyleBackColor = true;
            // 
            // grdVehicle
            // 
            this.grdVehicle.AllowUserToAddRows = false;
            this.grdVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVehicleCode,
            this.colVehicleType,
            this.colPlateNo,
            this.colStatus});
            this.grdVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVehicle.Location = new System.Drawing.Point(0, 0);
            this.grdVehicle.Name = "grdVehicle";
            this.grdVehicle.ReadOnly = true;
            this.grdVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVehicle.Size = new System.Drawing.Size(1176, 503);
            this.grdVehicle.TabIndex = 8;
            // 
            // colVehicleCode
            // 
            this.colVehicleCode.HeaderText = "Vehicle Code";
            this.colVehicleCode.Name = "colVehicleCode";
            this.colVehicleCode.ReadOnly = true;
            this.colVehicleCode.Width = 114;
            // 
            // colVehicleType
            // 
            this.colVehicleType.HeaderText = "Vehicle Type";
            this.colVehicleType.Name = "colVehicleType";
            this.colVehicleType.ReadOnly = true;
            this.colVehicleType.Width = 113;
            // 
            // colPlateNo
            // 
            this.colPlateNo.HeaderText = "Plate No.";
            this.colPlateNo.Name = "colPlateNo";
            this.colPlateNo.ReadOnly = true;
            this.colPlateNo.Width = 88;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 70;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 720);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 300);
            this.panel1.TabIndex = 11;
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.BackColor = System.Drawing.SystemColors.Control;
            this.flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp.Location = new System.Drawing.Point(0, 24);
            this.flp.Margin = new System.Windows.Forms.Padding(0);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(472, 276);
            this.flp.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vehicles expected to be on trip today";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.Shown += new System.EventHandler(this.DashboardForm_Shown);
            this.tc.ResumeLayout(false);
            this.tpOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tpSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTrip)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tpVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private VGLHelper.CustomControls.vglTabControl tc;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.TabPage tpSchedule;
        private System.Windows.Forms.TabPage tpVehicles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCreateTrip;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbWithNoOrders;
        private System.Windows.Forms.RadioButton rbWithOrders;
        private System.Windows.Forms.RadioButton rbAllTrips;
        private System.Windows.Forms.Label lblSchedules;
        private System.Windows.Forms.DataGridView grdVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label lblOrders;
        private VGLHelper.CustomControls.vglDataGridView grd;
        private VGLHelper.CustomControls.vglDataGridView grdTrip;
        private System.Windows.Forms.Label lblTripMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Label label1;
    }
}