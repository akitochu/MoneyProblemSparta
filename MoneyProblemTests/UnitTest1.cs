using Microsoft.VisualStudio.TestPlatform.TestHost;
using MoneyProblem;

namespace MoneyProblemTests
{
    public class Tests
    {
        [TestCase(5.47)]
        public void GivenAValidInput_MoneyProblem_ReturnsCorrectOutput(decimal value)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            output.Add("5", 1);
            output.Add("0.2", 2);
            output.Add("0.05", 1);
            output.Add("0.02", 1);

            Assert.That(MoneyProblem.Program.MoneyProblem(value), Is.EqualTo(output));
        }
        [TestCase(0)]
        public void GivenAZero_MoneyProblem_ReturnsEmptyDictionary(decimal value)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();

            Assert.That(MoneyProblem.Program.MoneyProblem(value), Is.EqualTo(output));
        }
        [TestCase(-5.23)]
        public void GivenANegitve_MoneyProblem_ReturnsArgumentException(decimal value)
        {
            Assert.That(() => MoneyProblem.Program.MoneyProblem(value), Throws.TypeOf<ArgumentException>());
        }
    }
}