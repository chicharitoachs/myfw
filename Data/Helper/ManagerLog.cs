using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DKC.Data.Helper
{
    public static class ManagerLog
    {
        static ManagerLog()
        {
            Logger = new NLogLogger();   
        }
        public static NLogLogger Logger { get; private set; }

    }

    public interface ILogger
    {
        void Info(string message);

        void Warn(string message);

        void Debug(string message);

        void Error(string message);
        void Error(string message, Exception x);
        void Error(Exception x);

        void Fatal(string message);
        void Fatal(Exception x);

    }
    public class NLogLogger : ILogger
    {
        private readonly Logger logger;

        public NLogLogger()
        {
            logger = LogManager.GetCurrentClassLogger();
        }

        public void Info(string message)
        {
            logger.Info(message);
        }

        public void Warn(string message)
        {
            logger.Warn(message);
        }

        public void Debug(string message)
        {
            logger.Debug(message);
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Error(Exception x)
        {
            Error(LogHelper.BuildExceptionMessage(x));
        }

        public void ErrorModel(List<string> x)
        {
            Error(LogHelper.BuildExceptionMessage(x));
        }

        public void Error(string message, Exception x)
        {
            logger.Error(new FormatException(message, x));
        }

        public void Fatal(string message)
        {
            logger.Fatal(message);
        }

        public void Fatal(Exception x)
        {
            Fatal(LogHelper.BuildExceptionMessage(x));
        }
    }
    
}