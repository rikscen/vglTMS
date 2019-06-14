using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using VGLHelper;
using VGLHelper.CustomControls;

namespace TMS.Utilities
{
    public static class UISetter
    {
        private const string PRIMARY_COLOR = "#3f51b5";
        private const string SECONDARY_COLOR = "#27ae60";

        public static void DoubleBuffered(this object obj, bool setting)
        {
            Type objType = obj.GetType();
            PropertyInfo pi = objType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(obj, setting, null);
        }

        public static void SetLabelAppearance(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                label.Height = 40;
                label.Font = new Font("ROBOTO", 16);
                label.BackColor = ColorTranslator.FromHtml(Etcetera.PRIMARY_COLOR_DARK);
                label.ForeColor = Color.White;
                label.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        public static void SetButtonAppearance(params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.BackColor = ColorTranslator.FromHtml(SECONDARY_COLOR);
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
        }

        public static void SetButtonAppearance(this Button button)
        {
            button.BackColor = ColorTranslator.FromHtml("#16a085");
            button.Font = new Font("Roboto", 12);
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }

        public static void SetCancelButtonAppearance(this Button button)
        {
            button.BackColor = ColorTranslator.FromHtml("#c62828");
            button.Font = new Font("Roboto", 12);
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }

        public static void SetGridAppearance(params DataGridView[] dataGridViews)
        {
            foreach (DataGridView datagridview in dataGridViews)
            {
                datagridview.BorderStyle = BorderStyle.None;
                datagridview.BackColor = ColorTranslator.FromHtml(Etcetera.PRIMARY_COLOR);
                datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.White;// ColorTranslator.FromHtml(Etcetera.PRIMARY_COLOR);
                datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;// ColorTranslator.FromHtml(Etcetera.ACCENT);
                datagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagridview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                datagridview.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(Etcetera.PRIMARY_COLOR);
                datagridview.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml(Etcetera.ACCENT);
                datagridview.RowsDefaultCellStyle.Padding = new Padding(10, 1, 10, 1);
                datagridview.RowsDefaultCellStyle.Font = new Font("Courier New", 10);
                datagridview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                datagridview.RowHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(Etcetera.PRIMARY_COLOR);
                datagridview.RowHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(Etcetera.ACCENT);
                //datagridview.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
                datagridview.RowTemplate.Height = 40;
                datagridview.ColumnHeadersHeight = 50;
                datagridview.BackgroundColor = ColorTranslator.FromHtml(Etcetera.ACCENT);
                datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                datagridview.EnableHeadersVisualStyles = false;
                //datagridview.AllowUserToAddRows = false;
                datagridview.DoubleBuffered(true);

                //datagridview.CellPainting += EventHandlers.Grid_CellPainting;
            }
        }

        public static void SetGridAppearance(this DataGridView datagridview)
        {
            datagridview.BorderStyle = BorderStyle.None;
            datagridview.BackColor = ColorTranslator.FromHtml(Etcetera.PRIMARY_COLOR);
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.White;// ColorTranslator.FromHtml(Etcetera.PRIMARY_COLOR);
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;// ColorTranslator.FromHtml(Etcetera.ACCENT);
            datagridview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridview.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml(Etcetera.PRIMARY_COLOR);
            datagridview.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml(Etcetera.ACCENT);
            datagridview.RowsDefaultCellStyle.Padding = new Padding(10, 1, 10, 1);
            datagridview.RowsDefaultCellStyle.Font = new Font("Courier New", 12);
            datagridview.ColumnHeadersDefaultCellStyle.Font = new Font("Courier New", 14, FontStyle.Bold);
            datagridview.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridview.RowHeadersDefaultCellStyle.Font = new Font("Courier New", 14, FontStyle.Bold);
            datagridview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagridview.RowHeadersDefaultCellStyle.BackColor = Color.White; // ColorTranslator.FromHtml(Etcetera.PRIMARY_COLOR);
            datagridview.RowHeadersDefaultCellStyle.ForeColor = Color.Black; // ColorTranslator.FromHtml(Etcetera.ACCENT);
            datagridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            //datagridview.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            datagridview.RowTemplate.Height = 50;
            datagridview.ColumnHeadersHeight = 50;
            datagridview.BackgroundColor = ColorTranslator.FromHtml(Etcetera.ACCENT);
            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //datagridview.AllowUserToAddRows = false;
            datagridview.DoubleBuffered(true);

            //datagridview.CellPainting += EventHandlers.Grid_CellPainting;
        }

        private static void DataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView grd = sender as DataGridView;
            if (e.IsLastVisibleRow)
                grd.Rows[0].Selected = false;
        }

        public static void SetComboBox(this ComboBox cbo, DataTable dt, string DisplayMember, string ValueMember, AutoCompleteSource AutoSource = AutoCompleteSource.ListItems,
                                            AutoCompleteMode AutoMode = AutoCompleteMode.SuggestAppend, ComboBoxStyle DropStyle = ComboBoxStyle.DropDownList)
        {
            cbo.DisplayMember = DisplayMember;
            cbo.ValueMember = ValueMember;
            cbo.AutoCompleteSource = AutoSource;
            cbo.AutoCompleteMode = AutoMode;
            cbo.DropDownStyle = DropStyle;
            cbo.DataSource = dt;
            cbo.SelectedIndex = -1;
        }

        public static DataGridViewComboBoxColumn SetDataGridViewComboBox(this DataGridViewComboBoxColumn cb, DataTable source, string displayMember, string valueMember)
        {
            cb.DisplayMember = displayMember;
            cb.ValueMember = valueMember;
            cb.DataSource = source;
            cb.DropDownWidth = 50;
            return cb;
        }

        public static void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tc = sender as TabControl;
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tc.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tc.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#3f51b5")), e.Bounds);
            }
            else
            {
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(new SolidBrush(ColorTranslator.FromHtml("#16a085")), e.Bounds);
            }

            // Use our own font.
            Font _tabFont = new Font("Roboto", (float)18.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
    }
}