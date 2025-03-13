using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Polymorphism
{
    abstract class Shape_Abstract
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();
        

        public void Select()
        {
            Console.WriteLine("Selected.");
        }

        public void Copy()
        {
            Console.WriteLine("Copied.");
        }
    }
    
    class Circle_Abstract : Shape_Abstract
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle.");
        }
    }

    class Rectangle_Abstract : Shape_Abstract
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle.");
        }
    }
}
