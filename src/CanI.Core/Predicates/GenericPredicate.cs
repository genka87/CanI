﻿using System;

namespace CanI.Core.Predicates
{
    public class GenericPredicate<T> : IAuthorizationPredicate
    {
        private readonly Func<T, bool> predicate;

        public GenericPredicate(Func<T, bool> predicate)
        {
            this.predicate = predicate;
        }

        public bool Allows(object subject)
        {
            if(subject is T)
                return predicate((T) subject);
            return true;
        }
    }
}