using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sherlok.Commands
{
    class gb
    {
        public static void garbage_collector()
        {
            long totalMemory = GC.GetTotalMemory(true);
            GC.WaitForPendingFinalizers();
            GC.Collect();
            //System.Windows.Forms.MessageBox.Show(Convert.ToString(totalMemory));
        }
    }
}
