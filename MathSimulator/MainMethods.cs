using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSimulator
{
    class MainMethods
    {
        public int Addition(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }

        public int Difference(int a, int b)
        {
            int c;
            c = a - b;
            return c;
        }

        public int Multiplication(int a, int b)
        {
            int c;
            c = a * b;
            return c;
        }

        public int Division(int a, int b)
        {
            int c;
            c = a / b;
            return c;
        }

        public int Comparsion(int a, int b)
        {
            int c;
            if (a > b) { c = 0; }
            else if (a < b) { c = 1; }
            else { c = 2; };
            return c;
        }

    }
}
