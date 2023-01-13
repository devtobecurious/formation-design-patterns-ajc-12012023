using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossTravailInterfaces
{
    internal class ColorConsoleLogger : ConsoleLogger
    {
        private readonly ConsoleColor color;

        public ColorConsoleLogger(ConsoleColor color)
        {
            this.color = color;
        }

        public override void Log(string message)
        {
            var oldColor = Console.ForegroundColor;

            Console.ForegroundColor = this.color;
            base.Log(message);
            Console.ForegroundColor = oldColor;
        }

        //public void Log(string message, ConsoleColor color)
        //{
        //    Console.ForegroundColor = color;

        //    base.Log(message);

        //    Console.ForegroundColor = ConsoleColor.White;
        //}
    }
}
