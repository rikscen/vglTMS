namespace TMS
{
    partial class CustomerRouteForm
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
            this.tc = new VGLHelper.CustomControls.vglTabControl();
            this.tpCustomer = new System.Windows.Forms.TabPage();
            this.grd = new System.Windows.Forms.DataGridView();
            this.tpRoute = new System.Windows.Forms.TabPage();
            this.grdRoute = new System.Windows.Forms.DataGridView();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tc.SuspendLayout();
            this.tpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.tpRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.AllowDrop = true;
            this.tc.BorderColor = System.Drawing.Color.Empty;
            this.tc.Controls.Add(this.tpCustomer);
            this.tc.Controls.Add(this.tpRoute);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.tc.ItemSize = new System.Drawing.Size(200, 50);
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.tc.Size = new System.Drawing.Size(1084, 561);
            this.tc.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc.TabBackColor = System.Drawing.Color.White;
            this.tc.TabIndex = 0;
            // 
            // tpCustomer
            // 
            this.tpCustomer.Controls.Add(this.btnUndo);
            this.tpCustomer.Controls.Add(this.btnSave);
            this.tpCustomer.Controls.Add(this.grd);
            this.tpCustomer.Location = new System.Drawing.Point(4, 54);
            this.tpCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpCustomer.Name = "tpCustomer";
            this.tpCustomer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpCustomer.Size = new System.Drawing.Size(1076, 503);
            this.tpCustomer.TabIndex = 0;
            this.tpCustomer.Text = "By Customer";
            this.tpCustomer.UseVisualStyleBackColor = true;
            // 
            // grd
            // 
            this.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Dock = System.Windows.Forms.DockStyle.Top;
            this.grd.Location = new System.Drawing.Point(3, 4);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(1070, 444);
            this.grd.TabIndex = 0;
            // 
            // tpRoute
            // 
            this.tpRoute.Controls.Add(this.grdRoute);
            this.tpRoute.Location = new System.Drawing.Point(4, 54);
            this.tpRoute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpRoute.Name = "tpRoute";
            this.tpRoute.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpRoute.Size = new System.Drawing.Size(1076, 452);
            this.tpRoute.TabIndex = 1;
            this.tpRoute.Text = "By Route";
            this.tpRoute.UseVisualStyleBackColor = true;
            // 
            // grdRoute
            // 
            this.grdRoute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRoute.Location = new System.Drawing.Point(3, 4);
            this.grdRoute.Name = "grdRoute";
            this.grdRoute.Size = new System.Drawing.Size(1070, 444);
            this.grdRoute.TabIndex = 1;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(793, 458);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(137, 37);
            this.btnUndo.TabIndex = 6;
            this.btnUndo.Text = "Undo Changes";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(936, 458);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // CustomerRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.tc);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerRouteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Route";
            this.tc.ResumeLayout(false);
            this.tpCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.tpRoute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRoute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VGLHelper.CustomControls.vglTabControl tc;
        private System.Windows.Forms.TabPage tpCustomer;
        private System.Windows.Forms.TabPage tpRoute;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.DataGridView grdRoute;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSave;
    }
}