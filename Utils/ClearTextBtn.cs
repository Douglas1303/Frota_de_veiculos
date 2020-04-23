using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin.Utils
{
    public static class ClearTextBtn
    {
        public static void ClearControls(this Control frm)
        {
            foreach (Control control in frm.Controls)
            {
                if (control is TextBox)
                {
                    control.ResetText();
                }

                if (control.Controls.Count > 0)
                {
                    control.ClearControls();
                }
            }
        }
    }
}
