﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using Nala.Framework.Extensions;

namespace Nala.Runner
{
    public class TypeFinder
    {
        public IReadOnlyCollection<Type> find(string filePath)
        {
            var assembly = Assembly.LoadFrom(filePath);
            var types = assembly.GetTypes();

            var result = types
                .Where(type =>
                type.GetTypeInfo().IsClass
                && !type.GetTypeInfo().IsAbstract
                && BaseTypes(type).Any(s => s == typeof(Framework.Nala)));

            return result
                .OrderBy(x => x.Name)
                .ToList()
                .AsReadOnly();
        }

        IEnumerable<Type> BaseTypes(Type type)
        {
            var types = new List<Type>();

            var currentType = type.GetTypeInfo().BaseType;

            while (currentType.IsNotNull())
            {
                types.Add(currentType);
                currentType = currentType.GetTypeInfo().BaseType;
            }

            return types;
        }
    }
}

