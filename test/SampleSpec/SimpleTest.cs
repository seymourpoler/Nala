namespace SampleSpec
{
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
}