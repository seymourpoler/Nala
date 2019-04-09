namespace SampleSpec
{
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
}