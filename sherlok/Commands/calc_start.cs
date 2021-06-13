using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sherlok.Commands
{
    class calc_start
    {
        public static void start()
        {
            string commandText = @"calc";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}
