namespace TMS
{
    partial class TripCalendarForm
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
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.InContentContextMenu = new DevComponents.DotNetBar.ButtonItem();
            this.InContentAddAppContextItem = new DevComponents.DotNetBar.ButtonItem();
            this.AppointmentContextMenu = new DevComponents.DotNetBar.ButtonItem();
            this.AppManageContextItem = new DevComponents.DotNetBar.ButtonItem();
            this.calendarView1 = new DevComponents.DotNetBar.Schedule.CalendarView();
            this.dateNavigator1 = new DevComponents.DotNetBar.Schedule.DateNavigator();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnDay = new DevComponents.DotNetBar.ButtonItem();
            this.btnMonth = new DevComponents.DotNetBar.ButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.DateTimePicker();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.btnTrip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.dateNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.contextMenuBar1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuBar1.IsMaximized = false;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.InContentContextMenu,
            this.AppointmentContextMenu});
            this.contextMenuBar1.Location = new System.Drawing.Point(244, 1);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(507, 29);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 58;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // InContentContextMenu
            // 
            this.InContentContextMenu.AutoExpandOnClick = true;
            this.InContentContextMenu.Name = "InContentContextMenu";
            this.InContentContextMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.InContentAddAppContextItem});
            this.InContentContextMenu.Text = "InContent";
            // 
            // InContentAddAppContextItem
            // 
            this.InContentAddAppContextItem.Name = "InContentAddAppContextItem";
            this.InContentAddAppContextItem.Text = "New Trip";
            this.InContentAddAppContextItem.Click += new System.EventHandler(this.MiNewTrip_Click);
            // 
            // AppointmentContextMenu
            // 
            this.AppointmentContextMenu.AutoExpandOnClick = true;
            this.AppointmentContextMenu.Name = "AppointmentContextMenu";
            this.AppointmentContextMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.AppManageContextItem});
            this.AppointmentContextMenu.Text = "Appointment";
            // 
            // AppManageContextItem
            // 
            this.AppManageContextItem.Name = "AppManageContextItem";
            this.AppManageContextItem.Text = "Manage Trip";
            this.AppManageContextItem.Click += new System.EventHandler(this.AppManageContextItem_Click);
            // 
            // calendarView1
            // 
            this.calendarView1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.calendarView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.calendarView1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendarView1.ContainerControlProcessDialogKey = true;
            this.calendarView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarView1.EnableDragCopy = false;
            this.calendarView1.EnableDragDrop = false;
            this.calendarView1.HighlightCurrentDay = true;
            this.calendarView1.IsMonthSideBarVisible = false;
            this.calendarView1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.calendarView1.Location = new System.Drawing.Point(10, 154);
            this.calendarView1.MultiUserTabHeight = 22;
            this.calendarView1.Name = "calendarView1";
            this.calendarView1.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Month;
            this.calendarView1.Size = new System.Drawing.Size(964, 497);
            this.calendarView1.TabIndex = 53;
            this.calendarView1.Text = "calendarView1";
            this.calendarView1.TimeIndicator.BorderColor = System.Drawing.Color.Empty;
            this.calendarView1.TimeIndicator.Tag = null;
            this.calendarView1.TimeSlotDuration = 30;
            this.calendarView1.ItemDoubleClick += new System.Windows.Forms.MouseEventHandler(this.calendarView1_ItemDoubleClick);
            this.calendarView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.calendarView1_MouseUp);
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.CalendarView = this.calendarView1;
            this.dateNavigator1.CanvasColor = System.Drawing.SystemColors.Control;
            this.dateNavigator1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateNavigator1.Controls.Add(this.contextMenuBar1);
            this.dateNavigator1.DisabledBackColor = System.Drawing.Color.Empty;
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateNavigator1.Location = new System.Drawing.Point(10, 124);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(964, 30);
            this.dateNavigator1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.dateNavigator1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.dateNavigator1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateNavigator1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.dateNavigator1.Style.GradientAngle = 90;
            this.dateNavigator1.TabIndex = 54;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDay,
            this.labelItem1,
            this.btnMonth});
            this.bar1.Location = new System.Drawing.Point(10, 82);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(964, 42);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 62;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnDay
            // 
            this.btnDay.Name = "btnDay";
            this.btnDay.Text = "Day";
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Text = "Month";
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTrip);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEnd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 72);
            this.panel1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Start Date";
            // 
            // txtEnd
            // 
            this.txtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEnd.Location = new System.Drawing.Point(244, 5);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(92, 23);
            this.txtEnd.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "End Date";
            // 
            // txtStart
            // 
            this.txtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStart.Location = new System.Drawing.Point(73, 5);
            this.txtStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(92, 23);
            this.txtStart.TabIndex = 52;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "|";
            this.labelItem1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnTrip
            // 
            this.btnTrip.BackColor = System.Drawing.Color.LightGreen;
            this.btnTrip.Location = new System.Drawing.Point(6, 34);
            this.btnTrip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTrip.Name = "btnTrip";
            this.btnTrip.Size = new System.Drawing.Size(76, 37);
            this.btnTrip.TabIndex = 56;
            this.btnTrip.Text = "Add Trip";
            this.btnTrip.UseVisualStyleBackColor = false;
            this.btnTrip.Click += new System.EventHandler(this.btnTrip_Click);
            // 
            // TripCalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.calendarView1);
            this.Controls.Add(this.dateNavigator1);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TripCalendarForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "TripCalendarForm";
            this.Load += new System.EventHandler(this.TripCalendarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.dateNavigator1.ResumeLayout(false);
            this.dateNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Schedule.CalendarView calendarView1;
        private DevComponents.DotNetBar.Schedule.DateNavigator dateNavigator1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem InContentContextMenu;
        private DevComponents.DotNetBar.ButtonItem InContentAddAppContextItem;
        private DevComponents.DotNetBar.ButtonItem AppointmentContextMenu;
        private DevComponents.DotNetBar.ButtonItem AppManageContextItem;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnDay;
        private DevComponents.DotNetBar.ButtonItem btnMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtStart;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private System.Windows.Forms.Button btnTrip;
    }
}