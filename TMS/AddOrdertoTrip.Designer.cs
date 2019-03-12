namespace TMS
{
    partial class AddOrdertoTrip
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
            this.header_grid = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.colShipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.header_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // header_grid
            // 
            this.header_grid.AllowUserToAddRows = false;
            this.header_grid.AllowUserToDeleteRows = false;
            this.header_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.header_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.header_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShipId,
            this.colRefDocDate,
            this.colRefDoc,
            this.colClient,
            this.colCustomer,
            this.colRoute,
            this.colDocValue,
            this.colTrip});
            this.header_grid.Location = new System.Drawing.Point(13, 14);
            this.header_grid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.header_grid.Name = "header_grid";
            this.header_grid.ReadOnly = true;
            this.header_grid.RowTemplate.Height = 28;
            this.header_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.header_grid.Size = new System.Drawing.Size(820, 367);
            this.header_grid.TabIndex = 48;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(744, 387);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 35);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // colShipId
            // 
            this.colShipId.DataPropertyName = "out_shipment_id";
            this.colShipId.HeaderText = "Out Shipment Id";
            this.colShipId.Name = "colShipId";
            this.colShipId.ReadOnly = true;
            this.colShipId.Width = 124;
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
            this.colRefDocDate.Width = 109;
            // 
            // colRefDoc
            // 
            this.colRefDoc.DataPropertyName = "Ref Doc";
            this.colRefDoc.HeaderText = "Ref Doc";
            this.colRefDoc.Name = "colRefDoc";
            this.colRefDoc.ReadOnly = true;
            this.colRefDoc.Width = 79;
            // 
            // colClient
            // 
            this.colClient.DataPropertyName = "client";
            this.colClient.HeaderText = "Client";
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            this.colClient.Width = 65;
            // 
            // colCustomer
            // 
            this.colCustomer.DataPropertyName = "name";
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            this.colCustomer.Width = 88;
            // 
            // colRoute
            // 
            this.colRoute.DataPropertyName = "route";
            this.colRoute.HeaderText = "Route";
            this.colRoute.Name = "colRoute";
            this.colRoute.ReadOnly = true;
            this.colRoute.Width = 66;
            // 
            // colDocValue
            // 
            this.colDocValue.DataPropertyName = "doc value";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colDocValue.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDocValue.HeaderText = "Document Value";
            this.colDocValue.Name = "colDocValue";
            this.colDocValue.ReadOnly = true;
            this.colDocValue.Width = 116;
            // 
            // colTrip
            // 
            this.colTrip.DataPropertyName = "trip";
            this.colTrip.HeaderText = "Trip";
            this.colTrip.Name = "colTrip";
            this.colTrip.ReadOnly = true;
            this.colTrip.Width = 55;
            // 
            // AddOrdertoTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 432);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.header_grid);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddOrdertoTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddOrdertoTrip";
            this.Load += new System.EventHandler(this.AddOrdertoTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.header_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView header_grid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefDocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrip;
    }
}