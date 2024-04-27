using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public class PanelEx : Panel
    {
        private int rotateAngle;

        public int RotateAngle
        {
            get { return rotateAngle; }
            set { rotateAngle = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(RotateAngle);
            e.Graphics.TranslateTransform(-this.Width / 2, -this.Height / 2);
            base.OnPaint(e);
        }
    }
}
