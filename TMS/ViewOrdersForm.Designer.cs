namespace TMS
{
    partial class ViewOrdersForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.grd = new System.Windows.Forms.DataGridView();
            this.colShipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 564);
            this.panel2.TabIndex = 13;
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
            this.grd.Size = new System.Drawing.Size(962, 456);
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
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(962, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Orders for Scheduling";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnSchedule);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(962, 84);
            this.panel4.TabIndex = 15;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchedule.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(749, 35);
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
            // ViewOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 564);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewOrdersForm";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.ViewOrdersForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShipId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefDocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label label3;
    }
}