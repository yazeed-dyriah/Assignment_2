using System;
namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the number of routes\n");
            RouteAndRouter[] routeAndRouters = new RouteAndRouter[n];

            for(int i = 0; i < n; i++)
            {
                routeAndRouters[i] = new RouteAndRouter();
                Console.WriteLine($"Insert the number of routers into the route\n");
                routeAndRouters[i].RoutersNumber = Convert.ToInt32(Console.ReadLine());
                routeAndRouters[i].RouterValue();
            }
        }
    }
}