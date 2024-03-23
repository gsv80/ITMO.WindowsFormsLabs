using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class WinAnim : Form
    {
        public WinAnim()
        {
            InitializeComponent();
        }

        private void btnAW_Blend_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.WinAPIClassFlags.AW_Activate | WinAPIClass.WinAPIClassFlags.AW_Blend);
            this.btnAW_Blend.Invalidate();
            this.btnAW_HorSlide.Invalidate();
            this.btnAW_CenterSlide.Invalidate();
        }

        private void btnAW_HorSlide_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.WinAPIClassFlags.AW_Hor_Positive | WinAPIClass.WinAPIClassFlags.AW_Slide);
            this.btnAW_Blend.Invalidate();
            this.btnAW_HorSlide.Invalidate();
            this.btnAW_CenterSlide.Invalidate();
        }

        private void btnAW_CenterSlide_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.WinAPIClassFlags.AW_Center | WinAPIClass.WinAPIClassFlags.AW_Slide);
            this.btnAW_Blend.Invalidate();
            this.btnAW_HorSlide.Invalidate();
            this.btnAW_CenterSlide.Invalidate();
        }
    }
}
