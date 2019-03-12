namespace TMS
{
    partial class TripCalendarWindow
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
            this.btnTrip = new System.Windows.Forms.Button();
            this.header_grid = new System.Windows.Forms.DataGridView();
            this.btnManageTrip = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRoute = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnChangeRoute = new System.Windows.Forms.Button();
            this.cbRoutes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.header_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrip
            // 
            this.btnTrip.BackColor = System.Drawing.Color.LightGreen;
            this.btnTrip.Location = new System.Drawing.Point(11, 63);
            this.btnTrip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTrip.Name = "btnTrip";
            this.btnTrip.Size = new System.Drawing.Size(76, 37);
            this.btnTrip.TabIndex = 47;
            this.btnTrip.Text = "Add Trip";
            this.btnTrip.UseVisualStyleBackColor = false;
            this.btnTrip.Click += new System.EventHandler(this.btnTrip_Click);
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
            this.header_grid.Location = new System.Drawing.Point(11, 106);
            this.header_grid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.header_grid.Name = "header_grid";
            this.header_grid.ReadOnly = true;
            this.header_grid.RowTemplate.Height = 50;
            this.header_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.header_grid.Size = new System.Drawing.Size(842, 379);
            this.header_grid.TabIndex = 46;
            this.header_grid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.header_grid_CellContentDoubleClick);
            // 
            // btnManageTrip
            // 
            this.btnManageTrip.BackColor = System.Drawing.Color.LightGreen;
            this.btnManageTrip.Location = new System.Drawing.Point(93, 63);
            this.btnManageTrip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnManageTrip.Name = "btnManageTrip";
            this.btnManageTrip.Size = new System.Drawing.Size(120, 37);
            this.btnManageTrip.TabIndex = 48;
            this.btnManageTrip.Text = "Manage Trip";
            this.btnManageTrip.UseVisualStyleBackColor = false;
            this.btnManageTrip.Click += new System.EventHandler(this.btnManageTrip_Click);
            // 
            // txtStart
            // 
            this.txtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStart.Location = new System.Drawing.Point(263, 26);
            this.txtStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(92, 23);
            this.txtStart.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "to";
            // 
            // txtEnd
            // 
            this.txtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEnd.Location = new System.Drawing.Point(382, 26);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(92, 23);
            this.txtEnd.TabIndex = 51;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightGreen;
            this.btnSearch.Location = new System.Drawing.Point(591, 74);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 26);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Trips";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRoute
            // 
            this.btnRoute.BackColor = System.Drawing.Color.LightGreen;
            this.btnRoute.Location = new System.Drawing.Point(680, 74);
            this.btnRoute.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(84, 26);
            this.btnRoute.TabIndex = 53;
            this.btnRoute.Text = "Routes";
            this.btnRoute.UseVisualStyleBackColor = false;
            this.btnRoute.Click += new System.EventHandler(this.btnRoutes_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.BackColor = System.Drawing.Color.LightGreen;
            this.btnDrop.Location = new System.Drawing.Point(769, 74);
            this.btnDrop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(84, 26);
            this.btnDrop.TabIndex = 54;
            this.btnDrop.Text = "Drops";
            this.btnDrop.UseVisualStyleBackColor = false;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // btnChangeRoute
            // 
            this.btnChangeRoute.BackColor = System.Drawing.Color.LightGreen;
            this.btnChangeRoute.Location = new System.Drawing.Point(680, 19);
            this.btnChangeRoute.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChangeRoute.Name = "btnChangeRoute";
            this.btnChangeRoute.Size = new System.Drawing.Size(84, 50);
            this.btnChangeRoute.TabIndex = 55;
            this.btnChangeRoute.Text = "Change Route";
            this.btnChangeRoute.UseVisualStyleBackColor = false;
            this.btnChangeRoute.Click += new System.EventHandler(this.btnChangeRoute_Click);
            // 
            // cbRoutes
            // 
            this.cbRoutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoutes.FormattingEnabled = true;
            this.cbRoutes.Location = new System.Drawing.Point(478, 26);
            this.cbRoutes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbRoutes.Name = "cbRoutes";
            this.cbRoutes.Size = new System.Drawing.Size(95, 25);
            this.cbRoutes.TabIndex = 56;
            // 
            // TripCalendarWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 497);
            this.Controls.Add(this.cbRoutes);
            this.Controls.Add(this.btnChangeRoute);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.btnRoute);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.btnManageTrip);
            this.Controls.Add(this.btnTrip);
            this.Controls.Add(this.header_grid);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TripCalendarWindow";
            this.Text = "TripCalendarWindow";
            this.Load += new System.EventHandler(this.TripCalendarWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.header_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrip;
        public System.Windows.Forms.DataGridView header_grid;
        private System.Windows.Forms.Button btnManageTrip;
        private System.Windows.Forms.DateTimePicker txtStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnChangeRoute;
        private System.Windows.Forms.ComboBox cbRoutes;
    }
}