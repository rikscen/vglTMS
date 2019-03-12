namespace TMS.Utilities
{
    partial class AddTripDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.DateTimePicker();
            this.txtEnd = new System.Windows.Forms.DateTimePicker();
            this.txtVehicle = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInCharge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "End Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehicle:";
            // 
            // txtStart
            // 
            this.txtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStart.Location = new System.Drawing.Point(83, 17);
            this.txtStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(157, 23);
            this.txtStart.TabIndex = 3;
            // 
            // txtEnd
            // 
            this.txtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEnd.Location = new System.Drawing.Point(83, 46);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(157, 23);
            this.txtEnd.TabIndex = 4;
            // 
            // txtVehicle
            // 
            this.txtVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtVehicle.FormattingEnabled = true;
            this.txtVehicle.Location = new System.Drawing.Point(83, 75);
            this.txtVehicle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(157, 25);
            this.txtVehicle.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(159, 136);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtInCharge
            // 
            this.txtInCharge.Location = new System.Drawing.Point(83, 106);
            this.txtInCharge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtInCharge.Name = "txtInCharge";
            this.txtInCharge.Size = new System.Drawing.Size(157, 23);
            this.txtInCharge.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "In Charge:";
            // 
            // AddTripDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 186);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInCharge);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtVehicle);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTripDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Trip";
            this.Load += new System.EventHandler(this.AddTripDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtStart;
        private System.Windows.Forms.DateTimePicker txtEnd;
        private System.Windows.Forms.ComboBox txtVehicle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInCharge;
        private System.Windows.Forms.Label label4;
    }
}