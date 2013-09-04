using System;

namespace CanI.Core.Authorization
{
    public interface IAbility
    {
        bool Allows(string action, object subject);
        Boolean Allows(RequestedActionOnSubject requestedActionOnSubject);
        bool AllowsExecutionOf(object command);
    }
}