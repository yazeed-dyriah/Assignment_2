using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class RouteAndRouter
    {

        public int Route
        {
            get;
            set;
        }
        public int RoutesNumber
        {
            get;
            set;
        }
        public int RoutersNumber
        {
            get;
            set;
        }
        public void RouterValue()
        {
            RouteAndRouter[] val = new RouteAndRouter[RoutersNumber];
            for (int i = 0; i < RoutersNumber; i++)
                val[i] = new RouteAndRouter();
            RouteAndRouter[] val2 = new RouteAndRouter[RoutersNumber];
        }
    }
}
