namespace TMS
{
    partial class ViewTripScheduleForm
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
            this.pnTripOverview = new System.Windows.Forms.Panel();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.colDropSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOrder = new System.Windows.Forms.Label();
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
            this.lblTripOverview = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnOrder = new System.Windows.Forms.Panel();
            this.lblScheduleOrder = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSelectedOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grd = new System.Windows.Forms.DataGridView();
            this.colShipId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTripOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnOrder.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTripOverview
            // 
            this.pnTripOverview.Controls.Add(this.grdOrders);
            this.pnTripOverview.Controls.Add(this.lblOrder);
            this.pnTripOverview.Controls.Add(this.panel6);
            this.pnTripOverview.Controls.Add(this.lblTripOverview);
            this.pnTripOverview.Controls.Add(this.panel5);
            this.pnTripOverview.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTripOverview.Location = new System.Drawing.Point(5, 5);
            this.pnTripOverview.Name = "pnTripOverview";
            this.pnTripOverview.Size = new System.Drawing.Size(1063, 566);
            this.pnTripOverview.TabIndex = 8;
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
            this.grdOrders.Size = new System.Drawing.Size(1063, 415);
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
            // lblOrder
            // 
            this.lblOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrder.Location = new System.Drawing.Point(0, 83);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(1063, 24);
            this.lblOrder.TabIndex = 12;
            this.lblOrder.Text = "Orders";
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
            // lblTripOverview
            // 
            this.lblTripOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTripOverview.Location = new System.Drawing.Point(0, 0);
            this.lblTripOverview.Name = "lblTripOverview";
            this.lblTripOverview.Size = new System.Drawing.Size(1063, 17);
            this.lblTripOverview.TabIndex = 2;
            this.lblTripOverview.Text = "Trip Schedule Overview";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 522);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1063, 44);
            this.panel5.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(847, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Orders";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(958, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnOrder
            // 
            this.pnOrder.Controls.Add(this.grd);
            this.pnOrder.Controls.Add(this.lblScheduleOrder);
            this.pnOrder.Controls.Add(this.panel4);
            this.pnOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnOrder.Location = new System.Drawing.Point(1068, 5);
            this.pnOrder.Name = "pnOrder";
            this.pnOrder.Size = new System.Drawing.Size(1063, 566);
            this.pnOrder.TabIndex = 14;
            this.pnOrder.Visible = false;
            // 
            // lblScheduleOrder
            // 
            this.lblScheduleOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScheduleOrder.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleOrder.Location = new System.Drawing.Point(0, 0);
            this.lblScheduleOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScheduleOrder.Name = "lblScheduleOrder";
            this.lblScheduleOrder.Size = new System.Drawing.Size(1063, 21);
            this.lblScheduleOrder.TabIndex = 10;
            this.lblScheduleOrder.Text = "Orders for Scheduling";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.btnSelectedOrder);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 522);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1063, 44);
            this.panel4.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(793, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 38);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSelectedOrder
            // 
            this.btnSelectedOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectedOrder.Location = new System.Drawing.Point(889, 6);
            this.btnSelectedOrder.Name = "btnSelectedOrder";
            this.btnSelectedOrder.Size = new System.Drawing.Size(174, 38);
            this.btnSelectedOrder.TabIndex = 52;
            this.btnSelectedOrder.Text = "Schedule Selected Orders";
            this.btnSelectedOrder.UseVisualStyleBackColor = true;
            this.btnSelectedOrder.Click += new System.EventHandler(this.btnSelectedOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Note: To select multiple orders; Hold and press CTRL + LEFT CLICK";
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShipId2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 21);
            this.grd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grd.Name = "grd";
            this.grd.RowTemplate.Height = 28;
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(1063, 501);
            this.grd.TabIndex = 50;
            // 
            // colShipId2
            // 
            this.colShipId2.DataPropertyName = "out_shipment_id";
            this.colShipId2.HeaderText = "Out Shipment Id";
            this.colShipId2.Name = "colShipId2";
            this.colShipId2.ReadOnly = true;
            this.colShipId2.Width = 124;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ref Doc Date";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ref Doc Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 109;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ref Doc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ref Doc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 79;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "client";
            this.dataGridViewTextBoxColumn4.HeaderText = "Client";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 65;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "customer_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 88;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "doc value";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn7.HeaderText = "Document Value";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 116;
            // 
            // ViewTripScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 576);
            this.Controls.Add(this.pnOrder);
            this.Controls.Add(this.pnTripOverview);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewTripScheduleForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trip Schedule Overview";
            this.Load += new System.EventHandler(this.ViewTripScheduleForm_Load);
            this.pnTripOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.pnOrder.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTripOverview;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDropSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefDocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocValue;
        private System.Windows.Forms.Label lblOrder;
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
        private System.Windows.Forms.Label lblTripOverview;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnOrder;
        private System.Windows.Forms.Label lblScheduleOrder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSelectedOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}