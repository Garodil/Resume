using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public static class Library
    {
        public static string TriangleSolver(string astr, string bstr, string cstr)
        {
            bool resulta = double.TryParse(astr, out double a);
            bool resultb = double.TryParse(bstr, out double b);
            bool resultc = double.TryParse(cstr, out double c);

            if (resulta && resultb && resultc)
            {
                double p = (a + b + c) / 2;

                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                if (Double.IsNaN(S))
                {
                    return ("Такого треугольника нет");
                }
                else return S.ToString();
            }
            else return ("Проверье числа в полях, возможно вы разделили десятичные знаки точкой, а не запятой, либо в ваши числа просочились буквы");
        }

        public static string RoundSolver(string rstr)
        {
            bool resultr = double.TryParse(rstr, out double r);
            if (resultr)
            {
                double S = Math.PI * Math.Pow(r, 2);
                if (Double.IsNaN(S))
                {
                    return "Такого окружности нет";
                }
                else return S.ToString();
            }
            else return "Проверье число в поле, возможно вы разделили десятичные знаки точкой, а не запятой, либо в ваше число просочились буквы";
        }
    }
}
