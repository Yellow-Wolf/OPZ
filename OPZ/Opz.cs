using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZ
{
    public class Opz
    {
        public static bool Open(char op)
        {
            if (("(".IndexOf(op) != -1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Close(char cl)
        {
            if ((")".IndexOf(cl) != -1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Operator(char o)
        {
            if (("+-/*^()".IndexOf(o) != -1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Sw(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 2;
                case '*': return 4;
                case '/': return 4;
                case '^': return 5;
                default: return 6;
            }
        }

        public static bool Razd(char r)
        {
            if ((" ".IndexOf(r) != -1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
