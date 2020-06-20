using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSimulator
{
    public class MainMethods
    {
        /// <summary>
        /// Додавання чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Addition(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }
        /// <summary>
        /// Віднімання чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Difference(int a, int b)
        {
            int c;
            c = a - b;
            return c;
        }
        /// <summary>
        /// Множення чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Multiplication(int a, int b)
        {
            int c;
            c = a * b;
            return c;
        }
        /// <summary>
        /// Ділення чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Division(int a, int b)
        {
            int c;
            c = a / b;
            return c;
        }
        /// <summary>
        /// Порівняння чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
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
