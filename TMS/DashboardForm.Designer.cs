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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grd = new System.Windows.Forms.DataGridView();
            this.colShipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnOrders = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tc = new System.Windows.Forms.TabControl();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.tpSchedule = new System.Windows.Forms.TabPage();
            this.pnAvailable = new System.Windows.Forms.Panel();
            this.grdVehicleWithTrip = new System.Windows.Forms.DataGridView();
            this.colTripId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpectedStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpectedEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIncharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOption = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbWithNoOrders = new System.Windows.Forms.RadioButton();
            this.rbWithOrders = new System.Windows.Forms.RadioButton();
            this.rbAllTrips = new System.Windows.Forms.RadioButton();
            this.lblSchedules = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCreateTrip = new System.Windows.Forms.Button();
            this.tpVehicles = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnOrders.SuspendLayout();
            this.tc.SuspendLayout();
            this.tpOrders.SuspendLayout();
            this.tpSchedule.SuspendLayout();
            this.pnAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicleWithTrip)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1292, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Orders for Scheduling";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vehicles expected to be on trip today";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.flp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 720);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 300);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1292, 557);
            this.panel2.TabIndex = 12;
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShipId,
            this.colRefDocDate,
            this.colRefDoc,
            this.colClient,
            this.colCustId,
            this.colCustName,
            this.colDocValue});
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 24);
            this.grd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grd.Name = "grd";
            this.grd.RowTemplate.Height = 28;
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(1292, 443);
            this.grd.TabIndex = 49;
            // 
            // colShipId
            // 
            this.colShipId.DataPropertyName = "out_shipment_id";
            this.colShipId.HeaderText = "Out Shipment Id";
            this.colShipId.Name = "colShipId";
            this.colShipId.ReadOnly = true;
            this.colShipId.Width = 104;
            // 
            // colRefDocDate
            // 
            this.colRefDocDate.DataPropertyName = "Ref Doc Date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.colRefDocDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colRefDocDate.HeaderText = "Ref Doc Date";
            this.colRefDocDate.Name = "colRefDocDate";
            this.colRefDocDate.ReadOnly = true;
            // 
            // colRefDoc
            // 
            this.colRefDoc.DataPropertyName = "Ref Doc";
            this.colRefDoc.HeaderText = "Ref Doc";
            this.colRefDoc.Name = "colRefDoc";
            this.colRefDoc.ReadOnly = true;
            this.colRefDoc.Width = 73;
            // 
            // colClient
            // 
            this.colClient.DataPropertyName = "client";
            this.colClient.HeaderText = "Client";
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            this.colClient.Width = 65;
            // 
            // colCustId
            // 
            this.colCustId.DataPropertyName = "customer_id";
            this.colCustId.HeaderText = "Customer";
            this.colCustId.Name = "colCustId";
            this.colCustId.ReadOnly = true;
            this.colCustId.Width = 88;
            // 
            // colCustName
            // 
            this.colCustName.DataPropertyName = "name";
            this.colCustName.HeaderText = "Customer Name";
            this.colCustName.Name = "colCustName";
            this.colCustName.ReadOnly = true;
            this.colCustName.Width = 114;
            // 
            // colDocValue
            // 
            this.colDocValue.DataPropertyName = "doc value";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colDocValue.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDocValue.HeaderText = "Document Value";
            this.colDocValue.Name = "colDocValue";
            this.colDocValue.ReadOnly = true;
            this.colDocValue.Width = 116;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnSchedule);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 467);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1292, 90);
            this.panel4.TabIndex = 15;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchedule.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(1079, 6);
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
            this.label3.Size = new System.Drawing.Size(386, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Note: To select multiple orders; Hold and press CTRL + LEFT CLICK";
            // 
            // pnOrders
            // 
            this.pnOrders.Controls.Add(this.panel2);
            this.pnOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnOrders.Location = new System.Drawing.Point(0, 0);
            this.pnOrders.Name = "pnOrders";
            this.pnOrders.Size = new System.Drawing.Size(1292, 557);
            this.pnOrders.TabIndex = 14;
            // 
            // tc
            // 
            this.tc.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tc.Controls.Add(this.tpOrders);
            this.tc.Controls.Add(this.tpSchedule);
            this.tc.Controls.Add(this.tpVehicles);
            this.tc.Dock = System.Windows.Forms.DockStyle.Top;
            this.tc.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc.HotTrack = true;
            this.tc.ItemSize = new System.Drawing.Size(200, 40);
            this.tc.Location = new System.Drawing.Point(5, 5);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1300, 605);
            this.tc.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc.TabIndex = 15;
            this.tc.Selected += new System.Windows.Forms.TabControlEventHandler(this.tc_Selected);
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.pnOrders);
            this.tpOrders.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpOrders.Location = new System.Drawing.Point(4, 44);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Size = new System.Drawing.Size(1292, 557);
            this.tpOrders.TabIndex = 0;
            this.tpOrders.Text = "Orders";
            // 
            // tpSchedule
            // 
            this.tpSchedule.Controls.Add(this.pnAvailable);
            this.tpSchedule.Location = new System.Drawing.Point(4, 44);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Size = new System.Drawing.Size(1292, 557);
            this.tpSchedule.TabIndex = 1;
            this.tpSchedule.Text = "Trip Schedules";
            // 
            // pnAvailable
            // 
            this.pnAvailable.Controls.Add(this.grdVehicleWithTrip);
            this.pnAvailable.Controls.Add(this.panel5);
            this.pnAvailable.Controls.Add(this.lblSchedules);
            this.pnAvailable.Controls.Add(this.panel3);
            this.pnAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAvailable.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnAvailable.Location = new System.Drawing.Point(0, 0);
            this.pnAvailable.Name = "pnAvailable";
            this.pnAvailable.Size = new System.Drawing.Size(1292, 557);
            this.pnAvailable.TabIndex = 5;
            // 
            // grdVehicleWithTrip
            // 
            this.grdVehicleWithTrip.AllowUserToAddRows = false;
            this.grdVehicleWithTrip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdVehicleWithTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehicleWithTrip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTripId,
            this.colVehicle,
            this.colExpectedStart,
            this.colExpectedEnd,
            this.colIncharge,
            this.colRoute,
            this.colLastUpdated,
            this.colOption});
            this.grdVehicleWithTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVehicleWithTrip.Location = new System.Drawing.Point(0, 62);
            this.grdVehicleWithTrip.Name = "grdVehicleWithTrip";
            this.grdVehicleWithTrip.ReadOnly = true;
            this.grdVehicleWithTrip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVehicleWithTrip.Size = new System.Drawing.Size(1292, 405);
            this.grdVehicleWithTrip.TabIndex = 3;
            this.grdVehicleWithTrip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVehicleWithTrip_CellContentClick);
            // 
            // colTripId
            // 
            this.colTripId.DataPropertyName = "trip_id";
            this.colTripId.HeaderText = "Trip No";
            this.colTripId.Name = "colTripId";
            this.colTripId.ReadOnly = true;
            this.colTripId.Width = 74;
            // 
            // colVehicle
            // 
            this.colVehicle.DataPropertyName = "vehicle";
            this.colVehicle.HeaderText = "Vehicle";
            this.colVehicle.Name = "colVehicle";
            this.colVehicle.ReadOnly = true;
            this.colVehicle.Width = 75;
            // 
            // colExpectedStart
            // 
            this.colExpectedStart.DataPropertyName = "expected_Start";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.colExpectedStart.DefaultCellStyle = dataGridViewCellStyle3;
            this.colExpectedStart.HeaderText = "Expected Start";
            this.colExpectedStart.Name = "colExpectedStart";
            this.colExpectedStart.ReadOnly = true;
            this.colExpectedStart.Width = 115;
            // 
            // colExpectedEnd
            // 
            this.colExpectedEnd.DataPropertyName = "expected_end";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            this.colExpectedEnd.DefaultCellStyle = dataGridViewCellStyle4;
            this.colExpectedEnd.HeaderText = "Expected End";
            this.colExpectedEnd.Name = "colExpectedEnd";
            this.colExpectedEnd.ReadOnly = true;
            this.colExpectedEnd.Width = 109;
            // 
            // colIncharge
            // 
            this.colIncharge.DataPropertyName = "in_charge";
            this.colIncharge.HeaderText = "In-charge";
            this.colIncharge.Name = "colIncharge";
            this.colIncharge.ReadOnly = true;
            this.colIncharge.Width = 87;
            // 
            // colRoute
            // 
            this.colRoute.DataPropertyName = "route";
            this.colRoute.HeaderText = "Route";
            this.colRoute.Name = "colRoute";
            this.colRoute.ReadOnly = true;
            this.colRoute.Width = 66;
            // 
            // colLastUpdated
            // 
            this.colLastUpdated.DataPropertyName = "last_updated_on";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.colLastUpdated.DefaultCellStyle = dataGridViewCellStyle5;
            this.colLastUpdated.HeaderText = "Last updated on";
            this.colLastUpdated.Name = "colLastUpdated";
            this.colLastUpdated.ReadOnly = true;
            this.colLastUpdated.Visible = false;
            this.colLastUpdated.Width = 124;
            // 
            // colOption
            // 
            this.colOption.HeaderText = "Option";
            this.colOption.Name = "colOption";
            this.colOption.ReadOnly = true;
            this.colOption.Text = "VIEW";
            this.colOption.UseColumnTextForButtonValue = true;
            this.colOption.Width = 51;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbWithNoOrders);
            this.panel5.Controls.Add(this.rbWithOrders);
            this.panel5.Controls.Add(this.rbAllTrips);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1292, 35);
            this.panel5.TabIndex = 5;
            // 
            // rbWithNoOrders
            // 
            this.rbWithNoOrders.AutoSize = true;
            this.rbWithNoOrders.Location = new System.Drawing.Point(175, 8);
            this.rbWithNoOrders.Name = "rbWithNoOrders";
            this.rbWithNoOrders.Size = new System.Drawing.Size(108, 21);
            this.rbWithNoOrders.TabIndex = 2;
            this.rbWithNoOrders.Text = "With no orders";
            this.rbWithNoOrders.UseVisualStyleBackColor = false;
            this.rbWithNoOrders.CheckedChanged += new System.EventHandler(this.rbWithNoOrders_CheckedChanged);
            // 
            // rbWithOrders
            // 
            this.rbWithOrders.AutoSize = true;
            this.rbWithOrders.Location = new System.Drawing.Point(78, 8);
            this.rbWithOrders.Name = "rbWithOrders";
            this.rbWithOrders.Size = new System.Drawing.Size(91, 21);
            this.rbWithOrders.TabIndex = 2;
            this.rbWithOrders.Text = "With orders";
            this.rbWithOrders.UseVisualStyleBackColor = false;
            this.rbWithOrders.CheckedChanged += new System.EventHandler(this.rbWithOrders_CheckedChanged);
            // 
            // rbAllTrips
            // 
            this.rbAllTrips.AutoSize = true;
            this.rbAllTrips.Checked = true;
            this.rbAllTrips.Location = new System.Drawing.Point(0, 8);
            this.rbAllTrips.Name = "rbAllTrips";
            this.rbAllTrips.Size = new System.Drawing.Size(72, 21);
            this.rbAllTrips.TabIndex = 2;
            this.rbAllTrips.TabStop = true;
            this.rbAllTrips.Text = "All Trips";
            this.rbAllTrips.UseVisualStyleBackColor = false;
            this.rbAllTrips.CheckedChanged += new System.EventHandler(this.rbAllTrips_CheckedChanged);
            // 
            // lblSchedules
            // 
            this.lblSchedules.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSchedules.Location = new System.Drawing.Point(0, 0);
            this.lblSchedules.Name = "lblSchedules";
            this.lblSchedules.Size = new System.Drawing.Size(1292, 27);
            this.lblSchedules.TabIndex = 2;
            this.lblSchedules.Text = "Ongoing Trip Schedules";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCreateTrip);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 467);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1292, 90);
            this.panel3.TabIndex = 4;
            // 
            // btnCreateTrip
            // 
            this.btnCreateTrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateTrip.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTrip.Location = new System.Drawing.Point(1151, 6);
            this.btnCreateTrip.Name = "btnCreateTrip";
            this.btnCreateTrip.Size = new System.Drawing.Size(142, 46);
            this.btnCreateTrip.TabIndex = 5;
            this.btnCreateTrip.Text = "Create Trip";
            this.btnCreateTrip.UseVisualStyleBackColor = true;
            this.btnCreateTrip.Click += new System.EventHandler(this.btnCreateTrip_Click);
            // 
            // tpVehicles
            // 
            this.tpVehicles.Location = new System.Drawing.Point(4, 44);
            this.tpVehicles.Name = "tpVehicles";
            this.tpVehicles.Size = new System.Drawing.Size(1292, 557);
            this.tpVehicles.TabIndex = 2;
            this.tpVehicles.Text = "Vehicles";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1310, 769);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.Shown += new System.EventHandler(this.DashboardForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnOrders.ResumeLayout(false);
            this.tc.ResumeLayout(false);
            this.tpOrders.ResumeLayout(false);
            this.tpSchedule.ResumeLayout(false);
            this.pnAvailable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicleWithTrip)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Panel pnOrders;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefDocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocValue;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.TabPage tpSchedule;
        private System.Windows.Forms.TabPage tpVehicles;
        private System.Windows.Forms.Panel pnAvailable;
        private System.Windows.Forms.DataGridView grdVehicleWithTrip;
        private System.Windows.Forms.Label lblSchedules;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCreateTrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTripId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpectedStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpectedEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIncharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdated;
        private System.Windows.Forms.DataGridViewButtonColumn colOption;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbWithNoOrders;
        private System.Windows.Forms.RadioButton rbWithOrders;
        private System.Windows.Forms.RadioButton rbAllTrips;
    }
}