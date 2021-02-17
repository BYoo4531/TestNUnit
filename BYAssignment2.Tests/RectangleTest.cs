using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYAssignment2.Tests
{
    [TestFixture]
    public class RectangleTest
    {
        [Test]
        public void GetLength_NoGiven_Result1()
        {
            // Arrange 
            Rectangle rect = new Rectangle();
            int expectedResult = 1;

            // Act 
            int actualResult = rect.GetLength();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetLength_Given5And5_Result5()
        {
            // Arrange 
            int length = 5;
            int width = 5;

            int expectedResult = 5;

            Rectangle rect = new Rectangle(length, width);

            // Act
            int actualResult = rect.GetLength();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetLength_GivenMaxAnd5_ResultMax()
        {
            // Arrange 
            int length = int.MaxValue;
            int width = 5;
            Rectangle rect = new Rectangle(length, width);

            int expectedResult = 2147483647;

            // Act
            int actualResult = rect.GetLength();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void SetLength_Given5_Result5()
        {
            // Arrange 
            int length = 5;
            Rectangle rect = new Rectangle();
            int expectedResult = 5;

            // Act 
            rect.SetLength(length);
            int actualResult = rect.GetLength();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetLength_Given20And20_Result20()
        {
            // Arrange 
            int initLength = 1;
            int width = 20;
            int length = 20;


            Rectangle rect = new Rectangle(initLength , width);
            int expectedResult = 20;

            // Act 
            rect.SetLength(length);
            int actualResult = rect.GetLength();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void SetLength_GivenNeg10_ResultException()
        {
            // Arrange 
            int length = -10;

            Rectangle rect = new Rectangle();
            
            // Act , Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => rect.SetLength(length));
        }


        [Test]
        public void GetWidth_NoGiven_Result1()
        {
            // Arrange 
            Rectangle rect = new Rectangle();
            int expectedResult = 1;

            // Act 
            int actualResult = rect.GetWidth();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetWidth_Given10And10_Result10()
        {
            // Arrange 
            int length = 10;
            int width = 10;

            int expectedResult = 10;

            Rectangle rect = new Rectangle(length, width);

            // Act
            int actualResult = rect.GetWidth();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetWidth_Given10AndMax_ResultMax()
        {
            // Arrange 
            int length = 10;
            int width = int.MaxValue;
            Rectangle rect = new Rectangle(length, width);

            int expectedResult = 2147483647;

            // Act
            int actualResult = rect.GetWidth();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void SetWidth_Given3_Result3()
        {
            // Arrange 
            int width = 3;
            Rectangle rect = new Rectangle();
            int expectedResult = 3;

            // Act 
            rect.SetWidth(width);
            int actualResult = rect.GetWidth();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetWidth_Given10_Result10()
        {
            // Arrange 
            int initLength = 1;
            int width = 10;


            Rectangle rect = new Rectangle(initLength, width);
            int expectedResult = 10;

            // Act 
            rect.SetWidth(width);
            int actualResult = rect.GetWidth();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void SetWidth_GivenNeg3_ResultException()
        {
            // Arrange 
            int width = -3;

            Rectangle rect = new Rectangle();

            // Act , Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => rect.SetWidth(width));
            
        }

        [Test]
        public void GetPerimeter_NoGiven_Result4()
        {
            // Arrange

            int expectedResult = 4;

            Rectangle rect = new Rectangle();

            // Act 
            int actualResult = rect.GetPerimeter();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Given3And5_Result16()
        {
            // Arrange
            int length = 3;
            int width = 5;

            int expectedResult = 16;

            Rectangle rect = new Rectangle(length, width);

            // Act 
            int actualResult = rect.GetPerimeter();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_GivenMAXAnd10_ResultException()
        {
            // Arrange
            int length = int.MaxValue;
            int width = 10;

            Rectangle rect = new Rectangle(length, width);

            // Act , Assert
            Assert.Throws<OverflowException>(() => rect.GetPerimeter());
        }


        [Test]
        public void GetArea_NoGiven_Result1()
        {
            // Arrange

            int expectedResult = 1;

            Rectangle rect = new Rectangle();

            // Act 
            int actualResult = rect.GetArea();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetArea_Given5And5_Result25()
        {
            // Arrange
            int length = 5;
            int width = 5;

            int expectedResult = 25;

            Rectangle rect = new Rectangle(length , width);

            // Act 
            int actualResult = rect.GetArea();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Given5AndMAX_ResultException()
        {
            // Arrange
            int length = 5;
            int width = int.MaxValue;

            Rectangle rect = new Rectangle(length , width);

            // Act , Assert
            Assert.Throws<OverflowException>(() => rect.GetArea());
        }



    }
}
