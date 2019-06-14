using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VGLHelper.CustomControls
{
    public class vglForm : Form
    {
        public vglTitleBar titleBar = new vglTitleBar();

        public vglForm() : base()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            FormBorderStyle = FormBorderStyle.None;
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(titleBar);
        }
    }
}