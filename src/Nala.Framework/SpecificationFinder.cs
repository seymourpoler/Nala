﻿using System;
using Nala.Framework.Extensions;

namespace Nala.Framework
{
    public class SpecificationFinder
    {
        private readonly ClassFinder classFinder;
        
        public SpecificationFinder(ClassFinder  classFinder)
        {
            this.classFinder = classFinder;
        }

        public Specification Find(Type type)
        {
            if (type.IsNull())
            {
                return Specification.CreateEmpty();
            }

            var context = classFinder.Find(type);
            var instance = type.CreateInstanceAs<Nala>();
            context.Build(instance);

            return context;
        }
    }
}
