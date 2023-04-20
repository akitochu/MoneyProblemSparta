namespace MoneyProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal amount = 5.47M;
            Dictionary<string, int> result = MoneyProblem(amount);
            foreach (KeyValuePair<string, int> kvp in result)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }
        }

        public static Dictionary<string, int> MoneyProblem(decimal value)
        {
            if (value < 0) throw new ArgumentException("Cant be less than zero");
            Dictionary<string, int> output = new Dictionary<string, int>();
            decimal[] denominations = { 20M, 10M, 5M, 2M, 1M, 0.5M, 0.2M, 0.1M, 0.05M, 0.02M, 0.01M };
            foreach (decimal denomination in denominations)
            {
                int count = (int)(value / denomination);
                if (count > 0)
                {
                    output.Add(denomination.ToString(), count);
                    value -= count * denomination;
                }
            }
            return output;
        }

    }
}