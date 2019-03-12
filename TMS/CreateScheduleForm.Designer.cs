namespace TMS
{
    partial class CreateScheduleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNav = new System.Windows.Forms.Button();
            this.lblTripOverview = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTripNo = new System.Windows.Forms.Label();
            this.cbRoute = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblTripEnd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIncharge = new System.Windows.Forms.Label();
            this.lblTripStart = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.colDropSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTripOverview = new System.Windows.Forms.Panel();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbWithNoOrders = new System.Windows.Forms.RadioButton();
            this.rbWithOrders = new System.Windows.Forms.RadioButton();
            this.rbAllTrips = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateTrip = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.pnTripOverview.SuspendLayout();
            this.pnAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicleWithTrip)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnBack);
            this.panel5.Controls.Add(this.btnNav);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 499);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1063, 44);
            this.panel5.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(848, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 38);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNav
            // 
            this.btnNav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNav.Location = new System.Drawing.Point(958, 6);
            this.btnNav.Name = "btnNav";
            this.btnNav.Size = new System.Drawing.Size(105, 38);
            this.btnNav.TabIndex = 8;
            this.btnNav.Text = "Save";
            this.btnNav.UseVisualStyleBackColor = true;
            this.btnNav.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // lblTripOverview
            // 
            this.lblTripOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTripOverview.Location = new System.Drawing.Point(0, 0);
            this.lblTripOverview.Name = "lblTripOverview";
            this.lblTripOverview.Size = new System.Drawing.Size(1063, 17);
            this.lblTripOverview.TabIndex = 2;
            this.lblTripOverview.Text = "Trip Schedule Overview";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.lblTripNo);
            this.panel6.Controls.Add(this.cbRoute);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.lblVehicle);
            this.panel6.Controls.Add(this.lblTripEnd);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.lblIncharge);
            this.panel6.Controls.Add(this.lblTripStart);
            this.panel6.Controls.Add(this.lblLastUpdated);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1063, 66);
            this.panel6.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trip No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(688, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Last updated on";
            // 
            // lblTripNo
            // 
            this.lblTripNo.BackColor = System.Drawing.Color.White;
            this.lblTripNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTripNo.Location = new System.Drawing.Point(63, 8);
            this.lblTripNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTripNo.Name = "lblTripNo";
            this.lblTripNo.Size = new System.Drawing.Size(150, 22);
            this.lblTripNo.TabIndex = 7;
            this.lblTripNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbRoute
            // 
            this.cbRoute.FormattingEnabled = true;
            this.cbRoute.Location = new System.Drawing.Point(520, 36);
            this.cbRoute.Name = "cbRoute";
            this.cbRoute.Size = new System.Drawing.Size(150, 25);
            this.cbRoute.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vehicle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Route";
            // 
            // lblVehicle
            // 
            this.lblVehicle.BackColor = System.Drawing.Color.White;
            this.lblVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicle.Location = new System.Drawing.Point(63, 36);
            this.lblVehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(150, 22);
            this.lblVehicle.TabIndex = 7;
            this.lblVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTripEnd
            // 
            this.lblTripEnd.BackColor = System.Drawing.Color.White;
            this.lblTripEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTripEnd.Location = new System.Drawing.Point(293, 36);
            this.lblTripEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTripEnd.Name = "lblTripEnd";
            this.lblTripEnd.Size = new System.Drawing.Size(150, 22);
            this.lblTripEnd.TabIndex = 7;
            this.lblTripEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "In-charge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Trip Start";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Trip End";
            // 
            // lblIncharge
            // 
            this.lblIncharge.BackColor = System.Drawing.Color.White;
            this.lblIncharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIncharge.Location = new System.Drawing.Point(520, 8);
            this.lblIncharge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncharge.Name = "lblIncharge";
            this.lblIncharge.Size = new System.Drawing.Size(150, 22);
            this.lblIncharge.TabIndex = 7;
            this.lblIncharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTripStart
            // 
            this.lblTripStart.BackColor = System.Drawing.Color.White;
            this.lblTripStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTripStart.Location = new System.Drawing.Point(293, 8);
            this.lblTripStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTripStart.Name = "lblTripStart";
            this.lblTripStart.Size = new System.Drawing.Size(150, 22);
            this.lblTripStart.TabIndex = 7;
            this.lblTripStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.BackColor = System.Drawing.Color.White;
            this.lblLastUpdated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastUpdated.Location = new System.Drawing.Point(793, 8);
            this.lblLastUpdated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(105, 22);
            this.lblLastUpdated.TabIndex = 7;
            this.lblLastUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrder
            // 
            this.lblOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrder.Location = new System.Drawing.Point(0, 83);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(1063, 24);
            this.lblOrder.TabIndex = 12;
            this.lblOrder.Text = "Orders";
            // 
            // grdOrders
            // 
            this.grdOrders.AllowUserToAddRows = false;
            this.grdOrders.AllowUserToDeleteRows = false;
            this.grdOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDropSequence,
            this.colShipId,
            this.colRefDocDate,
            this.colRefDoc,
            this.colClient,
            this.colCustId,
            this.colCustName,
            this.colDocValue});
            this.grdOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrders.Location = new System.Drawing.Point(0, 107);
            this.grdOrders.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.RowTemplate.Height = 28;
            this.grdOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrders.Size = new System.Drawing.Size(1063, 392);
            this.grdOrders.TabIndex = 50;
            // 
            // colDropSequence
            // 
            this.colDropSequence.DataPropertyName = "drop_sequence";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.NullValue = null;
            this.colDropSequence.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDropSequence.FillWeight = 60F;
            this.colDropSequence.HeaderText = "Drop Seq.";
            this.colDropSequence.MinimumWidth = 50;
            this.colDropSequence.Name = "colDropSequence";
            this.colDropSequence.ReadOnly = true;
            this.colDropSequence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDropSequence.Width = 62;
            // 
            // colShipId
            // 
            this.colShipId.DataPropertyName = "out_shipment_id";
            this.colShipId.HeaderText = "Out Shipment Id";
            this.colShipId.Name = "colShipId";
            this.colShipId.ReadOnly = true;
            this.colShipId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colShipId.Width = 85;
            // 
            // colRefDocDate
            // 
            this.colRefDocDate.DataPropertyName = "Ref Doc Date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colRefDocDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRefDocDate.FillWeight = 80F;
            this.colRefDocDate.HeaderText = "Ref Doc Date";
            this.colRefDocDate.Name = "colRefDocDate";
            this.colRefDocDate.ReadOnly = true;
            this.colRefDocDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colRefDocDate.Width = 81;
            // 
            // colRefDoc
            // 
            this.colRefDoc.DataPropertyName = "Ref Doc";
            this.colRefDoc.FillWeight = 80F;
            this.colRefDoc.HeaderText = "Ref Doc";
            this.colRefDoc.Name = "colRefDoc";
            this.colRefDoc.ReadOnly = true;
            this.colRefDoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colRefDoc.Width = 54;
            // 
            // colClient
            // 
            this.colClient.DataPropertyName = "client";
            this.colClient.FillWeight = 80F;
            this.colClient.HeaderText = "Client";
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            this.colClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colClient.Width = 46;
            // 
            // colCustId
            // 
            this.colCustId.DataPropertyName = "customer_id";
            this.colCustId.FillWeight = 80F;
            this.colCustId.HeaderText = "Customer";
            this.colCustId.Name = "colCustId";
            this.colCustId.ReadOnly = true;
            this.colCustId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCustId.Width = 69;
            // 
            // colCustName
            // 
            this.colCustName.DataPropertyName = "name";
            this.colCustName.HeaderText = "Customer Name";
            this.colCustName.Name = "colCustName";
            this.colCustName.ReadOnly = true;
            this.colCustName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCustName.Width = 95;
            // 
            // colDocValue
            // 
            this.colDocValue.DataPropertyName = "doc_value";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colDocValue.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDocValue.HeaderText = "Document Value";
            this.colDocValue.Name = "colDocValue";
            this.colDocValue.ReadOnly = true;
            this.colDocValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDocValue.Width = 97;
            // 
            // pnTripOverview
            // 
            this.pnTripOverview.Controls.Add(this.grdOrders);
            this.pnTripOverview.Controls.Add(this.lblOrder);
            this.pnTripOverview.Controls.Add(this.panel6);
            this.pnTripOverview.Controls.Add(this.lblTripOverview);
            this.pnTripOverview.Controls.Add(this.panel5);
            this.pnTripOverview.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTripOverview.Location = new System.Drawing.Point(1072, 9);
            this.pnTripOverview.Name = "pnTripOverview";
            this.pnTripOverview.Size = new System.Drawing.Size(1063, 543);
            this.pnTripOverview.TabIndex = 6;
            this.pnTripOverview.Visible = false;
            // 
            // pnAvailable
            // 
            this.pnAvailable.Controls.Add(this.grdVehicleWithTrip);
            this.pnAvailable.Controls.Add(this.panel1);
            this.pnAvailable.Controls.Add(this.label1);
            this.pnAvailable.Controls.Add(this.panel2);
            this.pnAvailable.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnAvailable.Location = new System.Drawing.Point(9, 9);
            this.pnAvailable.Name = "pnAvailable";
            this.pnAvailable.Size = new System.Drawing.Size(1063, 543);
            this.pnAvailable.TabIndex = 4;
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
            this.grdVehicleWithTrip.Location = new System.Drawing.Point(0, 52);
            this.grdVehicleWithTrip.Name = "grdVehicleWithTrip";
            this.grdVehicleWithTrip.ReadOnly = true;
            this.grdVehicleWithTrip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVehicleWithTrip.Size = new System.Drawing.Size(1063, 447);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.colExpectedStart.DefaultCellStyle = dataGridViewCellStyle4;
            this.colExpectedStart.HeaderText = "Expected Start";
            this.colExpectedStart.Name = "colExpectedStart";
            this.colExpectedStart.ReadOnly = true;
            this.colExpectedStart.Width = 115;
            // 
            // colExpectedEnd
            // 
            this.colExpectedEnd.DataPropertyName = "expected_end";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            this.colExpectedEnd.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.colLastUpdated.DefaultCellStyle = dataGridViewCellStyle6;
            this.colLastUpdated.HeaderText = "Last updated on";
            this.colLastUpdated.Name = "colLastUpdated";
            this.colLastUpdated.ReadOnly = true;
            this.colLastUpdated.Visible = false;
            // 
            // colOption
            // 
            this.colOption.HeaderText = "Option";
            this.colOption.Name = "colOption";
            this.colOption.ReadOnly = true;
            this.colOption.Text = "SELECT";
            this.colOption.UseColumnTextForButtonValue = true;
            this.colOption.Width = 51;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbWithNoOrders);
            this.panel1.Controls.Add(this.rbWithOrders);
            this.panel1.Controls.Add(this.rbAllTrips);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 35);
            this.panel1.TabIndex = 6;
            // 
            // rbWithNoOrders
            // 
            this.rbWithNoOrders.AutoSize = true;
            this.rbWithNoOrders.Location = new System.Drawing.Point(175, 7);
            this.rbWithNoOrders.Name = "rbWithNoOrders";
            this.rbWithNoOrders.Size = new System.Drawing.Size(108, 21);
            this.rbWithNoOrders.TabIndex = 3;
            this.rbWithNoOrders.Text = "With no orders";
            this.rbWithNoOrders.UseVisualStyleBackColor = false;
            this.rbWithNoOrders.CheckedChanged += new System.EventHandler(this.rbWithNoOrders_CheckedChanged);
            // 
            // rbWithOrders
            // 
            this.rbWithOrders.AutoSize = true;
            this.rbWithOrders.Location = new System.Drawing.Point(78, 7);
            this.rbWithOrders.Name = "rbWithOrders";
            this.rbWithOrders.Size = new System.Drawing.Size(91, 21);
            this.rbWithOrders.TabIndex = 4;
            this.rbWithOrders.Text = "With orders";
            this.rbWithOrders.UseVisualStyleBackColor = false;
            this.rbWithOrders.CheckedChanged += new System.EventHandler(this.rbWithOrders_CheckedChanged);
            // 
            // rbAllTrips
            // 
            this.rbAllTrips.AutoSize = true;
            this.rbAllTrips.Checked = true;
            this.rbAllTrips.Location = new System.Drawing.Point(0, 7);
            this.rbAllTrips.Name = "rbAllTrips";
            this.rbAllTrips.Size = new System.Drawing.Size(72, 21);
            this.rbAllTrips.TabIndex = 5;
            this.rbAllTrips.TabStop = true;
            this.rbAllTrips.Text = "All Trips";
            this.rbAllTrips.UseVisualStyleBackColor = false;
            this.rbAllTrips.CheckedChanged += new System.EventHandler(this.rbAllTrips_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1063, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Vehicle with Trip Schedule";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCreateTrip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 499);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 44);
            this.panel2.TabIndex = 4;
            // 
            // btnCreateTrip
            // 
            this.btnCreateTrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateTrip.Location = new System.Drawing.Point(958, 6);
            this.btnCreateTrip.Name = "btnCreateTrip";
            this.btnCreateTrip.Size = new System.Drawing.Size(105, 38);
            this.btnCreateTrip.TabIndex = 5;
            this.btnCreateTrip.Text = "Create Trip";
            this.btnCreateTrip.UseVisualStyleBackColor = true;
            this.btnCreateTrip.Click += new System.EventHandler(this.btnCreateTrip_Click);
            // 
            // CreateScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 561);
            this.Controls.Add(this.pnTripOverview);
            this.Controls.Add(this.pnAvailable);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateScheduleForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Schedule";
            this.Load += new System.EventHandler(this.CreateScheduleForm_Load);
            this.Shown += new System.EventHandler(this.CreateScheduleForm_Shown);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.pnTripOverview.ResumeLayout(false);
            this.pnAvailable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicleWithTrip)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNav;
        private System.Windows.Forms.Label lblTripOverview;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTripNo;
        private System.Windows.Forms.ComboBox cbRoute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblTripEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIncharge;
        private System.Windows.Forms.Label lblTripStart;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDropSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefDocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocValue;
        private System.Windows.Forms.Panel pnTripOverview;
        private System.Windows.Forms.Panel pnAvailable;
        private System.Windows.Forms.DataGridView grdVehicleWithTrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTripId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpectedStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpectedEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIncharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdated;
        private System.Windows.Forms.DataGridViewButtonColumn colOption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbWithNoOrders;
        private System.Windows.Forms.RadioButton rbWithOrders;
        private System.Windows.Forms.RadioButton rbAllTrips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateTrip;
    }
}