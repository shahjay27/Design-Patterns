using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class Circle   : Shape
    {
        private int _radius;

        public Circle(int radius, int x, int y, string color):base(x, y, color)
        {
            this._radius = radius;
        }

        public Circle(Circle circle):base(circle)
        {
            this._radius = circle._radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }

        public override void PrintAllDetails()
        {
            Console.WriteLine("Circle obj: Radius {0}, X {1}, Y {2}, Color {3}", this._radius, this._x, this._y, this._color);
        }
    }
}
