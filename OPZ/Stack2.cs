using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZ
{
    class Stack2
    {
        public double[] st2;
        public int top = 0;

        public Stack2(int g)
        {
            st2 = new double[g];
        }

        public bool Push(double d)
        {
            if (top < st2.Length)
            {
                st2[top++] = d;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Pop()
        {
            if (top > 0)
            {
                top--;
                return st2[top];
            }
            else
            {
                return '!';
            }
        }

        public double Peek()
        {
            return st2[top - 1];
        }

        public bool Empty()
        {
            return top == 0;
        }
    }
}
