using Fabrikam.Logging;

namespace Demo1
{
    class Customer
    {
        public string First { get; set; }
        public string Last { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var customer = new Customer
            {
                First = "Immo",
                Last = "Landwerth"
            };

            MyLogger.Instance.WriteLine("Starting application...");
            MyLogger.Instance.WriteLine(customer);
        }
    }
}
