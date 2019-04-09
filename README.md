# Nala 

[![Build Status](https://travis-ci.org/seymourpoler/Nala.svg?branch=master)](https://travis-ci.org/seymourpoler/Nala)

Nala is a BDD (Behavior Driven Development) testing framework of Specifications
flavor for .NET. Nala is intended to drive development by specifying behavior within
a declared specifications. Nala is heavily inspired by jasmine.

A basic Specification test:

```csharp
    public class SimpleTest : Nala.Framework.Nala
    {
        public void A_fail_test()
        {
            It("the test", () => { Expect("").ToBeNull(); });
        }
        
        public void A_success_test()
        {
            It("the test", () => { Expect<string>(null).ToBeNull(); });
        }
        
        public void A_describe_with_a_fail_test()
        {
            Describe("the describe of a fail test", () =>
            {
                It("the test", () => { Expect("").ToBeNull(); }); 
            });
        }
        
        public void A_describe_with_a_success_test()
        {
            Describe("the describe of a success test", () =>
            {
                It("the test", () => { Expect<string>(null).ToBeNull(); }); 
            });
        }
    }
```

A Specification with ignored test:

```csharp
    public class DescribeWithIgoredTest : Nala.Framework.Nala
    {
        public void Method_with_describe_an_ignored_test()
        {
            Describe("a describe with ignore test", () =>
            {
                XIt("ignored test", () => { throw new System.Exception(); });
            });
        }
        
        public void Method_with_ignored_describe_an_a_test()
        {
            XDescribe("a describe with ignore test", () =>
            {
                It("ignored test", () => { throw new System.Exception(); });
            });
        }
        
        public void Method_with_ignored_describe_an_ignored_test()
        {
            XDescribe("a describe with ignore test", () =>
            {
                XIt("ignored test", () => { throw new System.Exception(); });
            });
        }
        
        public void Method_with_ignored_describe_and_another_describe_and_a_test()
        {
            XDescribe("a describe with ignore test", () =>
            {
                Describe("another describe", () =>
                {
                    It("ignored test", () => { throw new System.Exception(); }); 
                });
            });
        }
        
        public void Method_with_ignored_describe_and_another_describe_with_another_describe_and_a_test()
        {
            XDescribe("a describe with ignore test", () =>
            {
                Describe("another describe", () =>
                {
                    Describe("another of another describe", () =>
                    {
                        It("ignored test", () => { throw new System.Exception(); }); 
                    }); 
                });
            });
        }
    }
```
