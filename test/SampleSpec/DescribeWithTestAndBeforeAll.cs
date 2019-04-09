using Nala.Framework;

namespace SampleSpec
{
    public class DescribeWithTestAndBeforeAll : Nala.Framework.Nala
    {
        public void a_describe_with_a_success_test_and_forEach_method()
        {
            describe("the describe of a success test with for each method", () =>
            {
                var beforeAllWasThrough = false;
                beforeAll(() => { beforeAllWasThrough = true;});
                it("a test", () => {expect(beforeAllWasThrough).ToBe(true);});
            });
            
            describe("the describe of a fail test with for each method", () =>
            {
                var beforeAllWasThrough = false;
                beforeAll(() => { beforeAllWasThrough = true;});
                it("a test", () => {expect(true).ToBe(false);});
            });
        }
    }
}