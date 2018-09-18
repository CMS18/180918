using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterfaceStruct
{
    public class Rectangle : Shape, ISurfaceCalculatable
    {
        private double Width;
        private double Height;

        public Rectangle(Point position, double width, double height)
        {
            base.Position = position;
            this.Width = width;
            this.Height = height;
        }

        public double CalculateSurface()
        {
            return Width * Height;
        }
    }
}
