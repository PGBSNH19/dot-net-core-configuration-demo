using Microsoft.Extensions.Configuration;
using System;

namespace ConfigDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();

            var defaultConnection = configuration.GetConnectionString("DefaultConnection");


            // Read config file
               // configuration bulider
            // Use config file

            Console.WriteLine($"Hello World! {defaultConnection}");
        }
    }
}
