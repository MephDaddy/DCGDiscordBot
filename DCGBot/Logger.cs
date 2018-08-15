using DCGBot.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace DCGBot
{
    class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);            
        }
    }
}
