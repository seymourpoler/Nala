using Nala.Framework;
using System;

namespace Nala.Runner
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string path = String.Empty;
#if DEBUG
            path = $"{System.Environment.CurrentDirectory}\\SampleSpec.dll";
#else
            path = args[0];
#endif

            var typeFinder = new TypeFinder();
            var specificationFinder = new SpecificationFinder(new ClassFinder(new MethodFinder()));
            var specificationWritter = new SpecificationWritter(new ConsoleWritter());

            var types = typeFinder.find(path);
            var specification = new Specification(path);
            foreach (var type in types)
            {
                var currentSpecification = specificationFinder.Find(type);
                specification.AddContext(currentSpecification);
            }
            specificationWritter.Write(specification);
        }
    }
}
