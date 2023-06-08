using System.Net.Security;
using System.Reflection.Emit;

namespace ClassLibrary
{
    public class Class1
    {
        public string TriangleSolver(string astr, string bstr, string cstr)
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
                    return("Такого треугольника нет");
                }
                else return(S.ToString());
            }
            else return ("Проверье числа в полях, возможно вы разделили десятичные знаки точкой, а не запятой, либо в ваши числа просочились буквы");
        }

        public void RoundSolver()
        {

        }
    }
}