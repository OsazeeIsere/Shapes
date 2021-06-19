using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with polymorphism");

            //make an array of shape-compactible objects
            Shape[] myShapes = {new Hexagon(),new Circle(),new Hexagon("Mick")
            ,new Circle("Beth"), new Hexagon("Linda")};

            //iterate or loop over each item and interact with the polym-
            //orphic interface
            foreach(Shape s in myShapes)
            {
                s.Draw();

            }
            //this calls the Draw() of the ThreeDCircle
            ThreeDCircle o = new ThreeDCircle("Susan");
            o.Draw();

            //this calls the Draw() method of the parent(explicit cast)

            ((Circle)o).Draw();

             Console.ReadLine();
        }
    }
}
