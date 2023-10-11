
namespace PrototypePattern
{
    internal class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height, int x, int y, string color) : base(x, y, color)
        {
            this._width = width;
            this._height = height;
        }

        public Rectangle(Rectangle rectangle):base(rectangle)
        {
            this._width = rectangle._width;
            this._height=rectangle._height;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }

        public override void PrintAllDetails()
        {
            Console.WriteLine("Rectangle obj: Width {0}, Height {1}, X {2}, Y {3}, Color {4}", this._width, this._height, this._x, this._y, this._color);
        }
    }
}
