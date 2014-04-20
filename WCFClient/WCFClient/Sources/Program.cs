using System;
using System.ServiceModel;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create WCF client instance
                CalculatorClient client = new CalculatorClient();

                // Call service operations
                double value1 = 100.00D;
                double value2 = 15.99D;
                double result = client.Add(value1, value2);
                Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

                value1 = 145.00D;
                value2 = 76.54D;
                result = client.Subtract(value1, value2);
                Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);

                value1 = 9.00D;
                value2 = 81.25D;
                result = client.Multiply(value1, value2);
                Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);

                value1 = 22.00D;
                value2 = 7.00D;
                result = client.Divide(value1, value2);
                Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);

                // Close the client
                client.Close();

                Console.WriteLine();
                Console.WriteLine("Press <ENTER> to terminate client.");
                Console.ReadLine();
            }
            catch (EndpointNotFoundException ex)
            {
                Console.WriteLine("Service endpoint not found: {0}", ex.Message);
                Console.ReadLine();
            }
            
        }
    }
}
