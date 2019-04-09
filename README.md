# Nala 

[![Build Status](https://travis-ci.org/seymourpoler/Nala.svg?branch=master)](https://travis-ci.org/seymourpoler/Nala)

Nala is a BDD (Behavior Driven Development) testing framework of Specifications
flavor for .NET. Nala is intended to drive development by specifying behavior within
a declared specifications. Nala is heavily inspired by jasmine.

A basic Specification test with Nala in csharp:

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
