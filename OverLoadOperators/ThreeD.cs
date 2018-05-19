using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadOperators
{
    class ThreeD
    {
        int x, y, z;

        public ThreeD()
        {
            x = y = z = 0;
        }
       
        public ThreeD(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }

        public static ThreeD operator + (ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;
            return result;
        }

        public static ThreeD operator +(ThreeD op1, int op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x + op2;
            result.y = op1.y + op2;
            result.z = op1.z + op2;
            return result;
        }

        static public ThreeD Fabrica(int i, int j, int k)
        {
            ThreeD t = new ThreeD(i, j, k);
            return t;
        }

        static public ThreeD Fabrica()
        {
            ThreeD t = new ThreeD();
            return t;
        }
        public void Show()
        {
            Console.WriteLine("x = {0}; y  = {1} z = {2}", x, y, z);
        }

    }
}
