using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Polymorphism
{
    class Shape_Overriding
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Shape created.");
        }
    }

    class Circle : Shape_Overriding
    {
        public override void Draw()
        {
            Console.WriteLine("Circle created.");
        }
    }

    class Rectangle : Shape_Overriding
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle created.");
        }
    }

    class Triangle : Shape_Overriding
    {
        public override void Draw()
        {
            Console.WriteLine("Triangle created.");
        }
    }


    class ShapeCreation
    {
        public void DrawShape(List<Shape_Overriding> shapes)
        {
            foreach (var shape in shapes)
                shape.Draw();
        }
    }
}
