﻿namespace collegeApp.MyLogging
{
    public class LogToDB : IMyLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("LogToDB");
            //write your own logic
        }
    }
}
