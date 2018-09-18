using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterfaceStruct
{
    public class Square : Shape, ISurfaceCalculatable
    {
        private double Size;

        public Square(Point position, double size)
        {
            this.Position = position;
            this.Size = size;
        }

        public double CalculateSurface()
        {
            return Size * Size;
        }
    }
}
