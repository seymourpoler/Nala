namespace SampleSpec
{
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
}