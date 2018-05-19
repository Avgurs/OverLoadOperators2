using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadOperators
{
    class ThreeDDemo

    {
        static void Main(string[] args)
        {
            ThreeD ob1 = ThreeD.Fabrica(1, 2, 5);
            ThreeD ob2 = ThreeD.Fabrica(5, -5, 10);
            ThreeD ob3 = ob1 + ob2;
            ob3.Show();
            Console.ReadKey();
        }

    }
}
