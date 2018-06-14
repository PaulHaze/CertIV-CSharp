using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_6_Rectangle
{
    public class Rectangle
    {
        // set the fields
        private double length;
        private double width;

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }

        // constructors 

        // default
        public Rectangle()
        {

        }
        // with parameters
        public Rectangle(double length, double  width)
        {
            this.Length = length;
            this.Width = width;
        }

        // functions

        public double RectangleArea()
        {
            return length * width;
        }

        public double RectanglePerimeter()
        {
            return (2 * length) + (2 * width);
        }

        public string RectangleInfo()
        {
            string msg = "";
            msg += $"Rectangle length: {length}\n";
            msg += $"Rectangle width: {width}\n";
            msg += $"Rectangle area: {RectangleArea()}\n";
            msg += $"Rectangle perimeter: {RectanglePerimeter()}\n";
            return msg;
        }


    }
}
