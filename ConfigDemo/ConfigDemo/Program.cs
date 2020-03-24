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
            var apiKey = configuration.GetSection("MySettings")["ApiKey"];


            Console.WriteLine($"Hello World! {defaultConnection}");
        }
    }
}
