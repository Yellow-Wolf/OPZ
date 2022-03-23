using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZ
{
    class Stack
    {
        public char[] st;
        public int top;

        public Stack(int a)
        {
            st = new char[a];
        }

        public bool Push(char f)
        {
            if (top < st.Length)
            {
                st[top++] = f;
                return true;
            }
            else
            {
                return false;
            }
        }

        public char Pop()
        {
            if (top > 0)
            {
                top--;
                return st[top];
            }
            else
            {
                return '!';
            }
        }

        public char Peek()
        {
            return st[top - 1];
        }

        public void Clear()
        {
            Array.Clear(st, 0, st.Length);
        }

        public bool Empty()
        {
            return top == 0;
        }
    }
}
