using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZ
{
    public class ToOpz
    {
        public static string OPZConv(string a)
        {
            string rez = string.Empty;
            var newSt = new Stack(a.Length);
            int i = 0;
            while (i < a.Length)
            {
                if (Char.IsDigit(a[i]) || Char.IsLetter(a[i]))
                {
                    while (i != a.Length && !Opz.Operator(a[i]))
                    {
                        rez += a[i++];
                    }
                    rez += " ";
                }
                if (i == a.Length)
                {
                    break;
                }

                if (Opz.Operator(a[i]))
                {
                    if (Opz.Open(a[i]))
                    {
                        newSt.Push(a[i]);
                    }
                    else if (Opz.Close(a[i]))
                    {
                        while (newSt.Peek() != '(')
                        {
                            rez += newSt.Pop().ToString();
                            rez += " ";
                        }
                        if (newSt.Peek() == '(')
                        {
                            newSt.Pop();
                        }
                    }
                    else
                    {
                        while (!newSt.Empty() && (Opz.Sw(newSt.Peek()) > Opz.Sw(a[i]) || Opz.Sw(newSt.Peek()) == Opz.Sw(a[i]) && a[i] != '^') && a[i] != '(')
                        {
                            rez += newSt.Pop().ToString();
                            rez += " ";
                        }
                        newSt.Push(a[i]);
                    }
                }
                i++;
            }
            while (newSt.Empty() == false)
            {
                rez += newSt.Pop();
                rez += " ";
            }
            return rez;
        }
    }
}
