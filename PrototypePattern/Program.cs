using PrototypePattern;


//List<Shape> shapesToClone = new List<Shape>();

Shape circle = new Circle(5, 6, 7, "black");
//shapesToClone.Add(circle);

Shape dupCircle = circle.Clone();
dupCircle.PrintAllDetails();
//shapesToClone.Add(dupCircle);

if (circle.Equals(dupCircle)) Console.WriteLine("False: this is a faulty cloned object.");

Shape rectangle = new Rectangle(5, 6, 7, 8, "blue");
//shapesToClone.Add(rectangle);

Shape dupRectangle = rectangle.Clone();
dupRectangle.PrintAllDetails();
//shapesToClone.Add(dupRectangle);

//foreach (Shape shape in shapesToClone)
//    shape.Clone();
