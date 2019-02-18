using System;
using System.Collections.Generic;

namespace DKC.Data.Helper
{
    public static class LogHelper
    {
        public static string BuildExceptionMessage(Exception x)
        {
            Exception logException = x;
            string strErrorMsg = Environment.NewLine + "Message :" + logException.Message;
            if (x.InnerException != null)
            {
                logException = x.InnerException;
                strErrorMsg += Environment.NewLine + "Message Inner:" + logException.Message;
            }

            strErrorMsg += Environment.NewLine + "InnerException Message :" + logException.InnerException?.Message + "; " + logException.InnerException?.InnerException?.Message;

            // Source of the message
            strErrorMsg += Environment.NewLine + "Source :" + logException.Source;

            // Stack Trace of the error

            strErrorMsg += Environment.NewLine + "Stack Trace :" + logException.StackTrace;

            // Method where the error occurred
            strErrorMsg += Environment.NewLine + "TargetSite :" + logException.TargetSite;
            return strErrorMsg;
        }
        public static string BuildExceptionMessage(List<string> errors)
        {
            string strErrorMsg = Environment.NewLine + "Error EntityModel:";

            // Get the error message
            foreach (var error in errors)
            {
                strErrorMsg += Environment.NewLine + "Message : " + error;
            }
            return strErrorMsg;
        }
    }
}