using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Figure
    {
        private string[] _sides;
        private double[] _doubles;

        /// <summary>
        /// Фигура
        /// </summary>
        /// <param name="sides">Длина одной из сторон вашей фигуры. Для получения окружности введите одну сторону, для треугольника три стороны</param>
        public Figure(params string[] sides) // Так как вам нужно получение площадь фигуры заранее неизвестного типа, решил сделать одним классом
        {
            for (int i = 0; i < sides.Length; i++)
            {
                sides[i] = sides[i].Replace('.', ',');
            }
            _sides = sides;
        }

        public string[] Sides
        { get { return _sides; } }

        public Figure(params double[] sides) 
        {
            _doubles = sides;
        }

        /// <summary>
        /// Возвращает площадь фигуры
        /// </summary>
        /// <returns>Площадь заданной фигуры</returns>
        public string FigureSolver()
        {
            foreach (string side in _sides)
            {
                if (string.IsNullOrEmpty(side) || side == "0") return "Неправильное значение: пустота или ноль";
            }

            switch (_sides.Length)
            {
                case 1: return RoundSolver(_sides[0]);
                case 3: return TriangleSolver(_sides[0], _sides[1], _sides[2]);
            }
            return "Фигура с таким количеством сторон ещё не поддерживается";
        }

        /// <summary>
        /// Вычисляет площадь треугольника по входящим строкам
        /// </summary>
        /// <param name="astr">Первая сторона</param>
        /// <param name="bstr">Вторая сторона</param>
        /// <param name="cstr">Третья сторона</param>
        /// <returns>Выводит площадь строкой и тип треугольника</returns>
        private string TriangleSolver(string astr, string bstr, string cstr) //Правильно было бы сделать всё с численными переменными, а не строчными. Я решил сделать всё строками, чтобы не загружать Form1 лишним кодом.
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
                    return ("Такого треугольника нет, сторона не может быть больше суммы двух других");
                }
                else return "Площадь: " + Math.Round(S, 2).ToString() + TriangleType(a, b, c); // Округление до двух знаков после запятой
            }
            else return ("Неправильное значение в поле");
        }

        private string RoundSolver(string rstr)
        {
            bool resultr = double.TryParse(rstr, out double r);
            if (resultr)
            {
                double S = Math.PI * Math.Pow(r, 2);
                if (Double.IsNaN(S))
                {
                    return "Такой окружности нет";
                }
                else return "Площадь: " + Math.Round(S, 2).ToString();
            }
            else return "Неправильное значение в поле";
        }
        
        /// <summary>
        /// Метод для определения типа треугольника с числами на вход
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        /// <returns>Выводит строку с названием типа треугольника</returns>
        public string TriangleType(double a, double b, double c) 
        {

            string type = "";

            if (a == b && b == c) return "\nЭто равносторонний треугольник";

            if (a == b && a != c || a == c && a != b || b == c && b != a) type = "\nЭто равнобедренный треугольник";

            double max, min1, min2;
            if (a > b && a > c)
            {
                max = a;
                min1 = b;
                min2 = c;
            }
            else if (b > c)
            {
                max = b;
                min1 = a;
                min2 = c;
            }
            else
            {
                max = c; min1 = a; min2 = b;
            }

            if (max == min1 + min2) return "\nЭто отрезок, одна из сторон не может равняться сумме двух других";

            if (Math.Pow(max, 2) == Math.Pow(min1, 2) + Math.Pow(min2, 2)) return type + "\nЭто прямоугольный треугольник";

            if (Math.Pow(max, 2) < Math.Pow(min1, 2) + Math.Pow(min2, 2)) return type + "\nЭто остроугольный треугольник";

            if (Math.Pow(max, 2) > Math.Pow(min1, 2) + Math.Pow(min2, 2)) return type + "\nЭто тупоугольный треугольник";


            return "\nНеизвестный тип треугольника";
        }
    }
}
