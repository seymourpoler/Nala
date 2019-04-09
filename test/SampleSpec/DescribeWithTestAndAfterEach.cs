namespace SampleSpec
{
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
}