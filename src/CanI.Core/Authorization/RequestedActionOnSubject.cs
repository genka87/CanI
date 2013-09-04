using System;

namespace CanI.Core.Authorization
{
    public class RequestedActionOnSubject
    {
        public RequestedActionOnSubject(String action, Object subject)
        {
            Subject = subject;
            Action = action;
        }

        public String Action { get; private set; }
        public Object Subject { get; private set; }
    }
}