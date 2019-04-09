using System;
using Nala.Framework.Expects;

namespace Nala.Framework
{
    public class Nala
    {
        public void Describe(string testSpecificationName, Action action)
        {          
            Specification.AddContext(new DescribeSpecification(testSpecificationName, action));
        }

        public void XDescribe(string testSpecificationName, Action action)
        {
            Specification.AddContext(new DescribeSpecification(testSuiteName: testSpecificationName, action: action, isIgnored: true));
        }

        public void BeforeAll(Action action)
        {
            Specification.BeforeAll = action;
        }

        public void AfterAll(Action action)
        {
            Specification.AfterAll = action;
        }

        public void BeforeEach(Action action)
        {
            Specification.BeforeEach = action;
        }

        public void AfterEach(Action action)
        {
            Specification.AfterEach = action;
        }

        public void It(string testName, Action action)
        {
            Specification.AddTest(new Test(name: testName, action: action));
        }

        public void XIt(string testName, Action action)
        {
            Specification.AddTest(new Test(name: testName, action:action, isIgnored: true));
        }

        public Expected<T> Expect<T>(T value)
        {
            return new Expected<T>(value);
        }

        internal Specification Specification { get; set; }
    }
}