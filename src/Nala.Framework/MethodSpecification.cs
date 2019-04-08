using System.Linq;
using System.Reflection;

namespace Nala.Framework
{
    public class MethodSpecification : Specification
    {
        private MethodInfo method;

        public MethodSpecification(MethodInfo method)
        : base(method.Name)
        {
            this.method = method;
        }

        public override void Build(Jasmine instance)
        {
            base.Build(instance);
            method.Invoke(instance, null);
            for (var position = 0; position < Specifications.Count(); position++)
            {
                Specifications[position].Build(instance);
            }
        }
    }
}