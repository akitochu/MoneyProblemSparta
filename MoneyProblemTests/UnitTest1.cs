using Microsoft.VisualStudio.TestPlatform.TestHost;
using MoneyProblem;

namespace MoneyProblemTests
{
    public class Tests
    {
        [TestCase(5.47)]
        public void GivenAValidInput_MoneyProblem_ReturnsCorrectOutput(double value)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            output.Add("£2", 2);
            output.Add("£1", 1);
            output.Add("20p", 2);
            output.Add("5p", 1);
            output.Add("2p", 1);

            Assert.That(MoneyProblem.Program.MoneyProblem(value), Is.EqualTo(output));
        }
        [TestCase(0)]
        public void GivenAZero_MoneyProblem_ReturnsEmptyDictionary(double value)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();

            Assert.That(MoneyProblem.Program.MoneyProblem(value), Is.EqualTo(output));
        }
        [TestCase(-5.23)]
        public void GivenANegitve_MoneyProblem_ReturnsArgumentException(double value)
        {
            Assert.That(() => MoneyProblem.Program.MoneyProblem(value), Throws.TypeOf<ArgumentException>());
        }
    }
}