using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Logger
{
    internal class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {
            base.writer = Console.Out;
        }

        public override void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
