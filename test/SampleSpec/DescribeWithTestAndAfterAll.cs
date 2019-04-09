namespace SampleSpec
{
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
}