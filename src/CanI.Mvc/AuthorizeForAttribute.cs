using System;

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

        public String Action
        {
            get { return action; }
        }

        public String Subject
        {
            get { return subject; }
        }
    }
}