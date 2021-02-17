using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true, exactLength = true, exactWidth = true, exactMenu = true;
            int length = 0, width = 0;

            do
            {
                do
                {
                    try
                    {
                        GetLength(out exactLength, out length);
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine(fe.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (exactLength);

                do
                {
                    try
                    {
                        GetWidth(out exactWidth, out width);
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine(fe.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (exactWidth);


                // Initialize Rectangle
                Rectangle rect = new Rectangle(length, width);

                do
                {
                    try
                    {
                        Console.WriteLine("------------------- MENU -----------------------");
                        Console.WriteLine("1. Get Rectangle Length");
                        Console.WriteLine("2. Change Rectangle Length");
                        Console.WriteLine("3. Get Rectangle Width");
                        Console.WriteLine("4. Change Rectangle Width");
                        Console.WriteLine("5. Get Rectangle Perimeter");
                        Console.WriteLine("6. Get Rectangle Area");
                        Console.WriteLine("7. Change Rectangle Length");
                        Console.Write(" Please choose menu number : ");
                        if (int.TryParse(Console.ReadLine(), out int menuNumber))
                        {
                            if (menuNumber >= 1 || menuNumber <= 7)
                            {
                                switch (menuNumber)
                                {
                                    case 1:
                                        Console.Write("The length of rectangle is ");
                                        Console.WriteLine(rect.GetLength());
                                        break;
                                    case 2:
                                        do
                                        {
                                            try
                                            {
                                                GetLength(out exactLength, out length);
                                            }
                                            catch (FormatException fe)
                                            {
                                                Console.WriteLine(fe.Message);
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine(e.Message);
                                            }
                                        } while (exactLength);

                                        rect.SetLength(length);

                                        break;
                                    case 3:
                                        Console.Write("The width of rectangle is ");
                                        Console.WriteLine(rect.GetWidth());
                                        break;
                                    case 4:
                                        do
                                        {
                                            try
                                            {
                                                GetWidth(out exactLength, out width);
                                            }
                                            catch (FormatException fe)
                                            {
                                                Console.WriteLine(fe.Message);
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine(e.Message);
                                            }
                                        } while (exactWidth);

                                        rect.SetWidth(width);

                                        break;
                                    case 5:
                                        Console.Write("The perimeter of rectangle is ");
                                        Console.WriteLine(rect.GetPerimeter());
                                        break;
                                    case 6:
                                        Console.Write("The area of rectangle is ");
                                        Console.WriteLine(rect.GetArea());
                                        break;
                                    case 7:
                                        exactMenu = false;
                                        keepGoing = false;
                                        break;
                                }
                            }
                            else
                            {
                                throw new Exception("You must enter the number from 1 to 7");
                            }
                        }
                        else
                        {
                            throw new FormatException("You must enter the number from 1 to 7");
                        }
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine(fe.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (exactMenu);





            } while (keepGoing);


        }

        private static void GetLength(out bool exactLength, out int length)
        {
            Console.Write("Please enter the length: ");
            if (int.TryParse(Console.ReadLine(), out int tempLength))
            {
                if (tempLength <= 0)
                {
                    throw new Exception("Please enter the length again greater than zero.");
                }

                exactLength = false;
                length = tempLength;

            }
            else
            {
                throw new FormatException("Please enter the length as a number greater than zero.");
            }
        }

        private static void GetWidth(out bool exactWidth, out int width)
        {
            Console.Write("Please enter the width: ");
            if (int.TryParse(Console.ReadLine(), out int tempWidth))
            {
                if (tempWidth <= 0)
                {
                    throw new Exception("Please enter the width again greater than zero.");
                }

                exactWidth = false;
                width = tempWidth;
            }
            else
            {
                throw new FormatException("Please enter the width as a number greater than zero.");
            }
        }
    }
}
