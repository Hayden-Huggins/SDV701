// Created by Hayden Huggins 20/06/2018
// This class is very mportant, as the entry point of our application, it starts up our selfhost server on port 60064
// This class holds the base URI format and begins to run

using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up server configuration
            Uri _baseAddress = new Uri("http://localhost:60064/");
            HttpSelfHostConfiguration config = new HttpSelfHostConfiguration(_baseAddress);
            config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{action}/{id}",
            defaults: new { id = RouteParameter.Optional }
            );
            // Create server
            HttpSelfHostServer server = new HttpSelfHostServer(config);
            // Start listening
            server.OpenAsync().Wait();
            Console.WriteLine("Bookstore Web-API Self hosted on " + _baseAddress);
            Console.WriteLine("Hit ENTER to exit...");
            Console.ReadLine();
            server.CloseAsync().Wait();
        }
    }
}
