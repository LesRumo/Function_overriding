using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_overriding
{
    internal class Shapes
    {
        public virtual void sides()
        {
            Console.WriteLine("All shapes have different sides");
        }
    }

    internal class Circle: Shapes
    {
            public override void sides()
    {
        Console.WriteLine(" a circle has no sides!");
    }

}



internal class Program
    {
        static void Main(string[] args)
        {
            Shapes shapes = new Shapes();
            shapes.sides();

            Circle circle = new Circle();
            circle.sides();


            Console.ReadLine();
        }
    }
}
