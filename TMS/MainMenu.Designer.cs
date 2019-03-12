namespace TMS
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tripUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolboxItem1 = new DevComponents.DotNetBar.Controls.ToolboxItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tripToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tripToolStripMenuItem
            // 
            this.tripToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tripCalendarToolStripMenuItem,
            this.toolStripSeparator1,
            this.tripUpdateToolStripMenuItem});
            this.tripToolStripMenuItem.Name = "tripToolStripMenuItem";
            this.tripToolStripMenuItem.Size = new System.Drawing.Size(55, 28);
            this.tripToolStripMenuItem.Text = "Trip";
            // 
            // tripCalendarToolStripMenuItem
            // 
            this.tripCalendarToolStripMenuItem.Name = "tripCalendarToolStripMenuItem";
            this.tripCalendarToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.tripCalendarToolStripMenuItem.Text = "Trip Calendar";
            this.tripCalendarToolStripMenuItem.Click += new System.EventHandler(this.tripCalendarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // tripUpdateToolStripMenuItem
            // 
            this.tripUpdateToolStripMenuItem.Name = "tripUpdateToolStripMenuItem";
            this.tripUpdateToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.tripUpdateToolStripMenuItem.Text = "Trip Update";
            this.tripUpdateToolStripMenuItem.Click += new System.EventHandler(this.tripUpdateToolStripMenuItem_Click);
            // 
            // toolboxItem1
            // 
            this.toolboxItem1.Name = "toolboxItem1";
            this.toolboxItem1.Symbol = "";
            this.toolboxItem1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.toolboxItem1.Text = "toolboxItem1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevComponents.DotNetBar.Controls.ToolboxItem toolboxItem1;
    }
}