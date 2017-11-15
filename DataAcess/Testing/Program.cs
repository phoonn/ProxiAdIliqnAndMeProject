﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Models;
using WCFServices;
using System.ServiceModel.Description;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8000/WCFService/");

            // Step 2 Create a ServiceHost instance  
            ServiceHost selfHost = new ServiceHost(typeof(WCFServices.LaptopCrudService), baseAddress);

            try
            {
                // Step 3 Add a service endpoint.  
                selfHost.AddServiceEndpoint(typeof(ICrudService<Laptop>), new WSHttpBinding(), "LaptopCrudService");

                // Step 4 Enable metadata exchange.  
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Step 5 Start the service.  
                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.  
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);

                Console.ReadLine();
                selfHost.Abort();
            }
        }
    }
}
