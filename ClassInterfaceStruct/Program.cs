using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterfaceStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1;
            p1.X = 10;
            p1.Y = 10;

            ISurfaceCalculatable r1 = new Rectangle(p1, 100, 100);

            Console.WriteLine(r1.CalculateSurface());

            if (r1 is Rectangle)
            {

            }




        }
    }
}
