using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLog = new FileLogger();
            fileLog.WriteLog();

            DatabaseLogger databaseLog = new DatabaseLogger();
            databaseLog.WriteLog();

            SmsLogger smsLog = new SmsLogger();
            smsLog.WriteLog();

            Console.WriteLine("***************");

            LogManager logManagerF = new LogManager(new FileLogger());
            logManagerF.WriteLog();

            LogManager logManagerDb = new LogManager(new DatabaseLogger());
            logManagerDb.WriteLog();

            LogManager logManagerSms = new LogManager(new SmsLogger());
            logManagerSms.WriteLog();
        }
    }
}
