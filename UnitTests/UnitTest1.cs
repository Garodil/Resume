using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary2;
using Resume;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FigureLengthTest()
        {
            string testString = "1.5";

            Figure testFigure = new Figure(testString);

            int testAnswer = 1;

            int testResult = testFigure.Sides.Length;

            Assert.AreEqual(testAnswer, testResult);
        }

        [TestMethod]
        public void FigureTest()
        {
            string testString = "1.5", testString1 = "1", testString2 = "2";

            Figure testFigure = new Figure(testString, testString1, testString2);

            string testAnswer = "2";

            string testResult = testFigure.Sides[2];

            Assert.AreEqual(testAnswer, testResult);
        }

        [TestMethod]
        public void RoundSolverTest()
        {
            string testString = "1.5";

            Figure testFigure = new Figure(testString);

            string testAnswer = "Площадь: 7,07";

            string testResult = testFigure.FigureSolver();

            Assert.AreEqual(testAnswer, testResult);
        }

        [TestMethod]
        public void WrongInputRoundSolverTest()
        {
            string testString = "agbea";

            Figure testFigure = new Figure(testString);

            string testAnswer = "Неправильное значение в поле";

            string testResult = testFigure.FigureSolver();

            Assert.AreEqual(testAnswer, testResult);
        }

        [TestMethod]
        public void TriangleSolverTest()
        {
            string a = "1.5", b = "1.5", c = "1.5";

            Figure testFigure = new Figure(a, b, c);

            string testAnswer = "Площадь: 0,97\nЭто равносторонний треугольник"; //По идее этот тест использует все методы, кроме RoundSolver, если он не справился, нужно смотреть именно на его конечный результат

            string testResult = testFigure.FigureSolver();

            Assert.AreEqual(testAnswer, testResult);
        }

        public void WrongInputTriangleSolverTest()
        {
            string a = "agbea", b = "1.5", c = "1.5";

            Figure testFigure = new Figure(a, b, c);

            string testAnswer = "Неправильное значение в поле";

            string testResult = testFigure.FigureSolver();

            Assert.AreEqual(testAnswer, testResult);
        }

        [TestMethod]
        public void RightTriangleTest()
        {
            double a = 3, b = 4, c = 5;

            Figure testFigure = new Figure(a, b, c);

            string testAnswer = "\nЭто прямоугольный треугольник";

            string testResult = testFigure.TriangleType(a, b, c);

            Assert.AreEqual(testAnswer, testResult);
        }

        [TestMethod]
        public void NoTriangleTest()
        {
            double a = 3, b = 3, c = 6;

            Figure testFigure = new Figure(a, b, c);

            string testAnswer = "\nЭто отрезок, одна из сторон не может равняться сумме двух других";

            string testResult = testFigure.TriangleType(a, b, c);

            Assert.AreEqual(testAnswer, testResult);
        }

        public void TriangleTypeTest()
        {
            double a = 2, b = 2, c = 3;

            Figure testFigure = new Figure(a, b, c);

            string testAnswer = "\nЭто равнобедренный треугольник\nЭто тупоугольный треугольник";

            string testResult = testFigure.TriangleType(a, b, c);

            Assert.AreEqual(testAnswer, testResult);

        }
    }
}
