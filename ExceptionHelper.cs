using System;

namespace Helper.Microservice
{
    public class ExceptionHelper
    {
        public static string GetMessages(Exception Exception, string Message = "")
        {
            if (Exception == null) return Message;

            var message = string.IsNullOrEmpty(Message) ? Exception.Message
                                                        : $"{Message}\\r\\n {Exception.Message}";
            
            return GetMessages(Exception.InnerException, message);
        }
    }
}
