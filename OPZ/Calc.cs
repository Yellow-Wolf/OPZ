using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZ
{
    public class Calc
    {
        public static double IzOPZ(string db)
        {
            double opzrez = 0;
            var newSt2 = new Stack2(db.Length);
            int i = 0;
            while (i < db.Length)
            {
                if (Char.IsDigit(db[i]) || Char.IsLetter(db[i]))
                {
                    string t = string.Empty;
                    while (i != db.Length && !Opz.Razd(db[i]) && !Opz.Operator(db[i]))
                    {
                        t += db[i];
                        i++;
                    }
                    newSt2.Push(double.Parse(t));
                }
                else if (Opz.Operator(db[i]))
                {
                    var a1 = newSt2.Pop();
                    var a2 = newSt2.Pop();
                    switch (db[i])
                    {
                        case '+':
                            opzrez = (a2 + a1);
                            break;
                        case '-':
                            opzrez = (a2 - a1);
                            break;
                        case '*':
                            opzrez = (a2 * a1);
                            break;
                        case '/':
                            opzrez = (a2 / a1);
                            break;
                        case '^':
                            opzrez = Math.Pow(double.Parse(a2.ToString()), double.Parse(a1.ToString()));
                            break;
                    }
                    newSt2.Push(opzrez);
                }
                if (i == db.Length)
                {
                    break;
                }
                i++;
            }
            return newSt2.Peek();
        }
    }
}
