using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class polymorphsim
    {
        public virtual void Draaw()
        {
            Console.WriteLine("drawing a shape");
        }
    }
    public class Ciircle : polymorphsim
    {
        public override void Draaw()
        {
            Console.WriteLine("drawing a circle");
        }
    }
    public class Reactangle : polymorphsim
    {
        public override Draaw()
        {
            Console.WriteLine("drawing a rectangle");
        }
    }

    class Program3
    {
        static void Main(string[]args)
        {
            polymorphsim shape1 = new Ciircle();
            polymorphsim shape2 = new Reactangle();
            shape1.Draaw();
            shape2.Draaw();

        }
    }
}
