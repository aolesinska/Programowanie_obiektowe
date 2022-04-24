using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Logger
{
    internal abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;
        private const string DateFormat = "yyyy-MM-ddTHH:mm:sszzz";
        public abstract void Dispose();
        public virtual void Log(params string[] messages)
        {
            DateTime time = DateTime.Now;
            writer.Write($"{time.ToString(DateFormat)} ");
            foreach (string m in messages)
                writer.Write($"{m} ");
            writer.Write('\n');
            writer.Flush();
        }
    }
}
