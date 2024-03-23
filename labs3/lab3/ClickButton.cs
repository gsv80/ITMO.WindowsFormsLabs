using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public class ClickButton:System.Windows.Forms.Button
    {
        int mClicks;
        public int Clicks
        {
            get { return mClicks; }
        }
        protected override void OnClick(EventArgs e)
        {
            mClicks++;
            base.OnClick(e);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            System.Drawing.Graphics g = pevent.Graphics;
            System.Drawing.SizeF stringSize;
            stringSize = g.MeasureString(Clicks.ToString(), this.Font, this.Width);
            g.DrawString(Clicks.ToString(),this.Font, System.Drawing.SystemBrushes.ControlText, this.Width- stringSize.Width-3, this.Height- stringSize.Height-3);
        }
    }
}
