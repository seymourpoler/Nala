﻿using System;
using Nala.Framework.Extensions;

namespace Nala.Framework
{
    public static class Check
    {
        public static void IsNull<TException>(object anObject)
        {
            if (anObject.IsNull())
            {
                throw  (Exception)Activator.CreateInstance(typeof(TException));
            }
            
        }
        
        public static void If<TException>(Func<bool> condition)
        {
            if (condition.Invoke())
            {
                throw  (Exception)Activator.CreateInstance(typeof(TException));
            }
            
        }
    }
}