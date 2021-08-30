using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBC_OOP_Square
{
    public class Square
    {
        private float side { get; set; }

        public float SideLenght
        {
            get { return side; }
            set { side = value; }
        }

        public Square(float _sideLenght)
        {
            side = _sideLenght;
        }

        public Square()
        {

        }

        /// <summary>
        /// Returns the lenght of the perimeter
        /// </summary>
        /// <returns></returns>
        public float GetPerimeter()
        {
            // 4 times the side lenght
            return side * 4;
        }

        /// <summary>
        /// Returns the area of the square
        /// </summary>
        /// <returns></returns>
        public float GetArea()
        {
            // Base * height (same in a square)
            return side * side;
        }
    }
}
