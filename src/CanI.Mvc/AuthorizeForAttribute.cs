using System;
using CanI.Core.Authorization;

namespace CanI.Mvc
{
    public class AuthorizeForAttribute : Attribute
    {
        private readonly String action;
        private readonly String subject;

        public AuthorizeForAttribute(String action, String subject)
        {
            this.action = action;
            this.subject = subject;
        }

        public RequestedActionOnSubject RequestedActionOnSubject
        {
            get { return new RequestedActionOnSubject(action, subject); }
        }
    }
}