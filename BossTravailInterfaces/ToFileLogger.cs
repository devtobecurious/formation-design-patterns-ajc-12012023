using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossTravailInterfaces
{
    internal class ToFileLogger : ILogger
    {
        private string path = string.Empty;

        public ToFileLogger(string path)
        {
            this.path = path;
        }

        public void Log(string message)
        {
            System.IO.File.WriteAllText(path, message);
        }
    }
}
