namespace TMS
{
    partial class ManageTrips
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
            this.header_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrip = new System.Windows.Forms.TextBox();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.txtTripStart = new System.Windows.Forms.TextBox();
            this.txtRoute = new System.Windows.Forms.TextBox();
            this.txtLastUpdatedOn = new System.Windows.Forms.TextBox();
            this.txtTripEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.header_grid.Location = new System.Drawing.Point(11, 117);
            this.header_grid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.header_grid.Name = "header_grid";
            this.header_grid.ReadOnly = true;
            this.header_grid.RowTemplate.Height = 28;
            this.header_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.header_grid.Size = new System.Drawing.Size(695, 212);
            this.header_grid.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Trip #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Vehicle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Trip Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Route";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Last Updated On";
            // 
            // txtTrip
            // 
            this.txtTrip.Location = new System.Drawing.Point(87, 13);
            this.txtTrip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTrip.Name = "txtTrip";
            this.txtTrip.ReadOnly = true;
            this.txtTrip.Size = new System.Drawing.Size(133, 23);
            this.txtTrip.TabIndex = 53;
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(87, 42);
            this.txtVehicle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.ReadOnly = true;
            this.txtVehicle.Size = new System.Drawing.Size(133, 23);
            this.txtVehicle.TabIndex = 54;
            // 
            // txtTripStart
            // 
            this.txtTripStart.Location = new System.Drawing.Point(313, 13);
            this.txtTripStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTripStart.Name = "txtTripStart";
            this.txtTripStart.ReadOnly = true;
            this.txtTripStart.Size = new System.Drawing.Size(133, 23);
            this.txtTripStart.TabIndex = 55;
            // 
            // txtRoute
            // 
            this.txtRoute.Location = new System.Drawing.Point(573, 38);
            this.txtRoute.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.ReadOnly = true;
            this.txtRoute.Size = new System.Drawing.Size(133, 23);
            this.txtRoute.TabIndex = 56;
            // 
            // txtLastUpdatedOn
            // 
            this.txtLastUpdatedOn.Location = new System.Drawing.Point(573, 10);
            this.txtLastUpdatedOn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLastUpdatedOn.Name = "txtLastUpdatedOn";
            this.txtLastUpdatedOn.ReadOnly = true;
            this.txtLastUpdatedOn.Size = new System.Drawing.Size(133, 23);
            this.txtLastUpdatedOn.TabIndex = 57;
            // 
            // txtTripEnd
            // 
            this.txtTripEnd.Location = new System.Drawing.Point(313, 39);
            this.txtTripEnd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTripEnd.Name = "txtTripEnd";
            this.txtTripEnd.ReadOnly = true;
            this.txtTripEnd.Size = new System.Drawing.Size(133, 23);
            this.txtTripEnd.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Trip End";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(11, 84);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(76, 27);
            this.btnOrder.TabIndex = 60;
            this.btnOrder.Text = "Add";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(91, 84);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 27);
            this.btnDelete.TabIndex = 61;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ManageTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 341);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtTripEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLastUpdatedOn);
            this.Controls.Add(this.txtRoute);
            this.Controls.Add(this.txtTripStart);
            this.Controls.Add(this.txtVehicle);
            this.Controls.Add(this.txtTrip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header_grid);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ManageTrips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageTrips";
            this.Load += new System.EventHandler(this.ManageTrips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.header_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView header_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrip;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.TextBox txtTripStart;
        private System.Windows.Forms.TextBox txtRoute;
        private System.Windows.Forms.TextBox txtLastUpdatedOn;
        private System.Windows.Forms.TextBox txtTripEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnDelete;
    }
}