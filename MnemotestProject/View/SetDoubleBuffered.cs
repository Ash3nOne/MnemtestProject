using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnemotestProject.View
{
    public static class SetDoubleBuffered
    {
        public static void Set(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp =
            typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

    }
}
