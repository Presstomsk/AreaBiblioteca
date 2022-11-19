using AreaBiblioteca.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaBiblioteca.Models
{
    public class Triangle : ITriangle
    {
        private double _a;
        private double _b;
        private double _c;
        private double _p;

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="a">Длина первой стороны</param>
        /// <param name="b">Длина второй стороны</param>
        /// <param name="c">Длина третьей стороны</param>
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        /// <exception cref="Exception">Ошибка данных</exception>
        public double GetArea()
        {
            if (_a > 0 && _b > 0 && _c > 0)
            {
                _p = (_a + _b + _c) / 2;
                return Math.Sqrt(_p * (_p - _a) * (_p - _b) * (_p - _c));
            }
            else throw new Exception("Incorrect triangle side values");
            
        }
        /// <summary>
        /// Проверка, является ли треугольник прямоугольным 
        /// </summary>
        /// <returns>Результат проверки</returns>
        /// <exception cref="Exception">Ошибка данных</exception>
        public bool IsRectangular()
        {
            if (_a > 0 && _b > 0 && _c > 0)
            {
                var biggestSide = default(double);
                var firstSmallSide = default(double);
                var secondSmallSide = default(double);

                if (_a > _b && _a > _c)
                {
                    biggestSide = _a;
                    firstSmallSide = _b;
                    secondSmallSide = _c;
                }
                else if (_b > _a && _b > _c)
                {
                    biggestSide = _b;
                    firstSmallSide = _a;
                    secondSmallSide = _c;
                }
                else
                {
                    biggestSide = _c;
                    firstSmallSide = _b;
                    secondSmallSide = _a;
                }

                return Math.Pow(biggestSide, 2) == Math.Pow(firstSmallSide, 2) + Math.Pow(secondSmallSide, 2);
            }
            else throw new Exception("Incorrect triangle side values");
        }
    }
}
