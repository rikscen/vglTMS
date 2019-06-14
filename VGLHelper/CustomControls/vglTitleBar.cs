using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace VGLHelper.CustomControls
{
    public class vglTitleBar : Panel
    {
        private string _text = "Insert title here";
        private StringAlignment vertical, horizontal;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public Button CloseButton = new Button();

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public vglTitleBar() : base()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            CloseButton.Dock = DockStyle.Right;
            Size = new Size(Size.Width, 40);
            Dock = DockStyle.Top;
            SetButton();
            Controls.Add(CloseButton);
        }

        [Category("Alignment")]
        public StringAlignment VerticalAlign
        {
            get { return vertical; }
            set { vertical = value; Invalidate(); }
        }

        [Category("Alignment")]
        public StringAlignment HorizontalAlign
        {
            get { return horizontal; }
            set { horizontal = value; Invalidate(); }
        }

        public string TitleText
        {
            get { return _text; }
            set { _text = value; Invalidate(); }
        }

        private Color _backColor = ColorTranslator.FromHtml(Etcetera.PRIMARY_COLOR_DARK);

        public override Color BackColor
        {
            get { return _backColor; }
            set { _backColor = value; Invalidate(); }
        }

        private Color _foreColor = ColorTranslator.FromHtml(Etcetera.ACCENT);

        public override Color ForeColor
        {
            get { return _foreColor; }
            set { _foreColor = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            var g = e.Graphics;

            using (var brush = new SolidBrush(Color.White))
            {
                brush.Color = BackColor;
                g.FillRectangle(brush, g.ClipBounds);

                brush.Color = ForeColor;
                g.DrawString(TitleText, Font, brush, new RectangleF(0, 0, ClientRectangle.Width - 40, ClientRectangle.Height), new StringFormat { LineAlignment = HorizontalAlign, Alignment = VerticalAlign });
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Parent.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                Invalidate();
            }
        }

        private void SetButton()
        {
            CloseButton.BackColor = ColorTranslator.FromHtml(Etcetera.PRIMARY_COLOR_DARK);
            CloseButton.ForeColor = ColorTranslator.FromHtml(Etcetera.ACCENT);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml(Etcetera.PRIMARY_COLOR_DARK);
            CloseButton.Size = new Size(40, CloseButton.Size.Height);
            CloseButton.Paint += EventHandlers.xButton_Paint;
            CloseButton.Click += CloseButton_Click;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            Application.OpenForms[button.Parent.Parent.Name].Close();
        }
    }
}