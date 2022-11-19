using AreaBiblioteca.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaBiblioteca.Models
{
    public class Circle : IFigure
    {
        private double _radius;

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {            
            _radius = radius;
        }       
        
        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        /// <exception cref="Exception">Ошибка данных</exception>
        public double GetArea()
        {
            if (_radius > 0)
            {
                return 2 * Math.PI * Math.Pow(_radius, 2);
            }
            else throw new Exception("Incorrect radius of circle");
            
        }
    }
}
