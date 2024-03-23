using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public class WinAPIClass
    {
        [Flags]
        public enum WinAPIClassFlags:int 
        {
            #region
            /// <summary>
            /// 
            /// </summary>
            AW_Hor_Positive = 1,
            AW_Hor_Negative = 2,
            AW_Vert_Positive = 4, 
            AW_Vert_Negative = 8,
            AW_Center  = 16,
            AW_Hide = 65536,
            AW_Activate = 131072,
            AW_Slide = 262144,
            AW_Blend = 524288
        };
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="dwTime"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [DllImportAttribute("user32.dll",EntryPoint ="AnimateWindow",SetLastError = true)]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="dwTime"></param>
        /// <param name="Flags"></param>
        /// <returns></returns>
        public static bool AnimateWindow(Control ctrl, int dwTime, WinAPIClassFlags Flags)
        {
            return AnimateWindow(ctrl.Handle, dwTime, (int)Flags);
        }
            #endregion

    }
}
