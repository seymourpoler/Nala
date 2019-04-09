namespace SampleSpec
{
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
}