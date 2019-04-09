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
A Specification with BeforeEach:

```csharp
    public class DescribeWithSuccessTestAndForEach : Nala.Framework.Nala
    {
        public void A_describe_with_a_success_test_and_forEach_method()
        {
            Describe("the describe of a success test with for each  method", () =>
            {
                var value = 0;
                BeforeEach(() => { value++;});
                It("the test with for each for each method", () => { Expect(value).ToBe(1); });
                It("another test with for each for each method", () => { Expect(value).ToBe(2); });
            });
        }
        
        public void A_describe_with_a_fail_test_and_forEach_method()
        {
            Describe("the describe of a fail test with for each  method", () =>
            {
                var value = 0;
                BeforeEach(() => { value++;});
                It("the test with for each for each method", () => { Expect(value).ToBe(1); });
                It("another test with for each for each method", () =>
                {
                    Expect(value).ToBe(2);
                    Expect("").ToBeNull();
                });
            });
        }
    }
```
A Specification with BeforeAll:

```csharp
    public class DescribeWithTestAndBeforeAll : Nala.Framework.Nala
    {
        public void A_describe_with_a_success_test_and_forEach_method()
        {
            Describe("the describe of a success test with for each method", () =>
            {
                var beforeAllWasThrough = false;
                BeforeAll(() => { beforeAllWasThrough = true;});
                It("a test", () => {Expect(beforeAllWasThrough).ToBe(true);});
            });
            
            Describe("the describe of a fail test with for each method", () =>
            {
                var beforeAllWasThrough = false;
                BeforeAll(() => { beforeAllWasThrough = true;});
                It("a test", () => {Expect(true).ToBe(false);});
            });
        }
    }
```

A Specification with AfterEach:

```csharp
    public class DescribeWithTestAndAfterEach : Nala.Framework.Nala
    {
        public void A_describe_with_a_success_test_and_afterEach_method()
        {
            Describe("the describe of a success test with after each method", () =>
            {
                var value = 2;
                AfterEach(() => { value++;});
                It("the test with for each for each method", () => { Expect(value).ToBe(2); });
                It("another test with for each for each method", () => { Expect(value).ToBe(1); });
            });
        }
        
        public void A_describe_with_a_fail_test_and_afterEach_method()
        {
            Describe("the describe of a fail test with after each method", () =>
            {
                var value = 0;
                AfterEach(() => { value++;});
                It("the test with for each for each method", () => { Expect(value).ToBe(2); });
                It("another test with for each for each method", () =>
                {
                    Expect(value).ToBe(1);
                    Expect("").ToBeNull();
                });
            });
        }
    }
```

A Specification with AfterAll:

```csharp
    public class DescribeWithTestAndAfterAll : Nala.Framework.Nala
    {
        public void A_describe_with_a_success_test_and_after_all_method()
        {
            Describe("the describe of a success test with after all method", () =>
            {
                AfterAll(() => { Expect(true).ToBe(true);});
                It("a test", () => {Expect(false).ToBe(true);});
            });
        }
        
        public void A_describe_with_a_fail_test_and_after_all_method()
        {          
            Describe("the describe of a fail test with after all method", () =>
            {
                AfterAll(() => { Expect(true).ToBe(true); });
                It("a test", () => {Expect(true).ToBe(true);});
            });
        }
    }
```
