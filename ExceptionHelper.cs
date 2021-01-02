using System;

namespace Helper.Microservice
{
    public class ExceptionHelper
    {
        public static string GetMessages(Exception Exception, string Message = "", bool IsFile = false)
        {
            if (Exception == null) return Message;

            var breakLine = (IsFile) ? "\\r\\n" : string.Empty;

            var message = string.IsNullOrEmpty(Message) ? Exception.Message
                                                        : $"{Message}{breakLine} {Exception.Message}";

            return GetMessages(Exception.InnerException, message, IsFile);
        }
    }
}
