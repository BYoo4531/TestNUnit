using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYAssignment2
{
    public class Rectangle
    {
        private int length;
        private int width;

        /// <summary>
        /// Default constructor
        /// which set the length and width each to the value of 1
        /// </summary>
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        /// <summary>
        /// non-default constructor 
        /// which sets the length and width to whatever the user input
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        /// <summary>
        /// Getter of length
        /// </summary>
        /// <returns>length</returns>
        public int GetLength()
        {
            return length;
        }

        /// <summary>
        /// Setter of length
        /// </summary>
        /// <param name="length"></param>
        public void SetLength(int length)
        {
            if (length > 0) {
                this.length = length;
            } else
            {
                throw new ArgumentOutOfRangeException("The length must be greater than 0.");
            }
        }

        /// <summary>
        /// Getter of width
        /// </summary>
        /// <returns> width </returns>
        public int GetWidth()
        {
            return width;
        }

        /// <summary>
        /// Setter of width
        /// </summary>
        /// <param name="width"></param>
        public void SetWidth(int width)
        {
            if (width > 0)
            {
                this.width = width;
            } else
            {
                throw new ArgumentOutOfRangeException("The width must be greater than 0");
            }
        }

        /// <summary>
        /// Get rectangle's perimeter
        /// </summary>
        /// <returns>rectangle's perimeter</returns>
        public int GetPerimeter()
        {
            try
            {
                return checked((2 * (length + width)));
            } catch (OverflowException e)
            {
                throw new OverflowException("The result value is overflowed.");
            }
        }

        /// <summary>
        /// Get rectangle's area
        /// </summary>
        /// <returns>rectangle's area</returns>
        public int GetArea()
        {
            try
            {
                return checked((length * width));
            } catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                throw new OverflowException("The result value is overflowed.");
            }
            
        }

    }
}
