using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    public class DataBaseLogger : ILogger
    {
        
           
            public void log()
            {
                Console.WriteLine("Veri tabanına loglandı");
            }
       
    }
}
