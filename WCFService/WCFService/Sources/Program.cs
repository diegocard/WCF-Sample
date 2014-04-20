using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Microsoft.ServiceModel.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            // URI to serve as base address
            Uri baseAddress = new Uri("http://localhost:8000/ServiceModelSamples/Service");
            // Create Service host
            ServiceHost selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);
            try
            {
                // Add a service endpoint
                selfHost.AddServiceEndpoint(
                    // Contract
                    typeof(ICalculator),
                    // Binding
                    new WSHttpBinding(),
                    // Address
                    "CalculatorService");

                // Enable metadata exchange
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Start and then stop the service
                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate the service");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("An exception occurred: {0}", ex.Message);
                selfHost.Abort();
            }
        }
    }
}
