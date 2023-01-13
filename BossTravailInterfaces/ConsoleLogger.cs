using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossTravailInterfaces
{
    internal class ConsoleLogger : ILogger
    {
        public virtual void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
