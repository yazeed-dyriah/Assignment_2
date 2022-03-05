using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class SyncAndAsync
    {
        public static async Task Print()
        {
            var task = new Task(() =>
            {
                RouteAndRouter route = new RouteAndRouter();
                Console.WriteLine("The best async route is: ", route,"\n");
            });
            await task;
        }
    }
    
    public void BestRoute()
    {
        Console.WriteLine("the best sync route is: ");
        Thread.Sleep(100);
        RouteAndRouter route = new RouteAndRouter();
        Console.WriteLine( route);
    }
}