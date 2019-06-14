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
            this.pnTripOverview = new System.Windows.Forms.Panel();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.lblOrder = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblHelper2 = new System.Windows.Forms.Label();
            this.lblHelper3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblHelper1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTripNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.btnPrint2 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnOrder = new System.Windows.Forms.Panel();
            this.grd = new System.Windows.Forms.DataGridView();
            this.lblScheduleOrder = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSelectedOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblplate = new System.Windows.Forms.Label();
            this.pnTripOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.grdOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrders.Location = new System.Drawing.Point(0, 132);
            this.grdOrders.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.RowTemplate.Height = 28;
            this.grdOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrders.Size = new System.Drawing.Size(1063, 390);
            this.grdOrders.TabIndex = 50;
            // 
            // lblOrder
            // 
            this.lblOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrder.Location = new System.Drawing.Point(0, 108);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(1063, 24);
            this.lblOrder.TabIndex = 12;
            this.lblOrder.Text = "Orders";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblplate);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.lblHelper2);
            this.panel6.Controls.Add(this.lblHelper3);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.lblDriver);
            this.panel6.Controls.Add(this.lblHelper1);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.lblTripNo);
            this.panel6.Controls.Add(this.label4);
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
            this.panel6.Size = new System.Drawing.Size(1063, 91);
            this.panel6.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(452, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Helper 2";
            // 
            // lblHelper2
            // 
            this.lblHelper2.BackColor = System.Drawing.Color.White;
            this.lblHelper2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHelper2.Location = new System.Drawing.Point(520, 64);
            this.lblHelper2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelper2.Name = "lblHelper2";
            this.lblHelper2.Size = new System.Drawing.Size(150, 22);
            this.lblHelper2.TabIndex = 25;
            this.lblHelper2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHelper3
            // 
            this.lblHelper3.BackColor = System.Drawing.Color.White;
            this.lblHelper3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHelper3.Location = new System.Drawing.Point(756, 64);
            this.lblHelper3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelper3.Name = "lblHelper3";
            this.lblHelper3.Size = new System.Drawing.Size(150, 22);
            this.lblHelper3.TabIndex = 26;
            this.lblHelper3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(688, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "Helper 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Driver";
            // 
            // lblDriver
            // 
            this.lblDriver.BackColor = System.Drawing.Color.White;
            this.lblDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDriver.Location = new System.Drawing.Point(63, 64);
            this.lblDriver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(150, 22);
            this.lblDriver.TabIndex = 21;
            this.lblDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHelper1
            // 
            this.lblHelper1.BackColor = System.Drawing.Color.White;
            this.lblHelper1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHelper1.Location = new System.Drawing.Point(293, 64);
            this.lblHelper1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelper1.Name = "lblHelper1";
            this.lblHelper1.Size = new System.Drawing.Size(150, 22);
            this.lblHelper1.TabIndex = 22;
            this.lblHelper1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Helper 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trip No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(688, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 15);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vehicle";
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
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "In-charge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Trip Start";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
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
            this.panel5.Controls.Add(this.btnPrint2);
            this.panel5.Controls.Add(this.btnPrint);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 522);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1063, 44);
            this.panel5.TabIndex = 4;
            // 
            // btnPrint2
            // 
            this.btnPrint2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint2.Location = new System.Drawing.Point(625, 6);
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(105, 38);
            this.btnPrint2.TabIndex = 11;
            this.btnPrint2.Text = "Print";
            this.btnPrint2.UseVisualStyleBackColor = true;
            this.btnPrint2.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(736, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 38);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 21);
            this.grd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grd.Name = "grd";
            this.grd.RowTemplate.Height = 28;
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(1063, 501);
            this.grd.TabIndex = 50;
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
            this.label1.Size = new System.Drawing.Size(384, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Note: To select multiple orders; Hold and press CTRL + LEFT CLICK";
            // 
            // lblplate
            // 
            this.lblplate.AutoSize = true;
            this.lblplate.Location = new System.Drawing.Point(170, 40);
            this.lblplate.Name = "lblplate";
            this.lblplate.Size = new System.Drawing.Size(49, 15);
            this.lblplate.TabIndex = 27;
            this.lblplate.Text = "Vehicle";
            this.lblplate.Visible = false;
            // 
            // ViewTripScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 576);
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
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTripOverview;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTripNo;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrint2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblHelper2;
        private System.Windows.Forms.Label lblHelper3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblHelper1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblplate;
    }
}