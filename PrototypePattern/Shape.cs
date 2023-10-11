
namespace PrototypePattern
{
    internal abstract class Shape
    {
        protected int _x;
        protected int _y;
        protected string _color;

        public Shape(int x, int y, string color) 
        {
            this._x = x;    
            this._y = y;
            this._color = color;
        }

        public Shape(Shape shape)
        {
            this._x = shape._x;
            this._y = shape._y;
            this._color = shape._color;
        }

        public abstract Shape Clone();
        public abstract void PrintAllDetails();
    }
}
