using System;

namespace Interfaces
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Writes and sends the log history as sms.");
        }
    }
}