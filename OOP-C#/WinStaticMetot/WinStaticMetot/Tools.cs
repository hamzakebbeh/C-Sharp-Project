using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinStaticMetot
{
    class Tools
    {
        public static void Temizle(Control c)
        {
            (c as ComboBox).Items.Clear();
        }
    }
}
