using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sherlok.Commands
{
    class help_start
    {
        public static void start()
        {
            string commandText = @"\\192.168.1.253\f\kostyukov\test\help\help.pdf";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}
