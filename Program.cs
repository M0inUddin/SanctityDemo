using System;
using System.Threading;//for using thread.sleep method

namespace Lab02
{
    class Program //this is demo repositpory select the end is near
    {
        public void menu()
        {
            string choice = "-1";
            //asdfadsf

            // changes

            const float pi = 3.14f;

            while (choice != "0")
            {
                Thread.Sleep(5000);//pausing control for 1sec

                Console.Clear();
                
                Console.WriteLine("\n\tPress + to Addition numbers:");
                Console.WriteLine("\tPress - to Subtract numbers:");
                Console.WriteLine("\tPress / to Divide numbers:");
                Console.WriteLine("\tPress * to Multiply numbers:");
                Console.WriteLine("\tPress % to Modules numbers:");
                Console.WriteLine("\tPress s for Squreroot of number:");
                Console.WriteLine("\tPress r for Rounding a number:");
                Console.WriteLine("\tPress c for checking numbers:");//comparison 
                Console.WriteLine("\tEnter max for finding maxmimum number:");
                Console.WriteLine("\tEnter min for finding minimum number:");
                Console.WriteLine("\tEnter A for finding area of Circle:");
                Console.WriteLine("\tPress 0 to Exit: \n\n");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "+":
                        {
                            Console.Clear();
                            int sum = 0;
                            Console.WriteLine("Enter the amount of Number you want to add: ");
                            int i = Convert.ToInt32(Console.ReadLine());

                            for (int j = 0; j < i; j++)
                            {
                                Console.WriteLine("Enter Number: ");
                                int num1 = Convert.ToInt32(Console.ReadLine());

                                sum += num1;
                            }

                            Console.WriteLine("Answer of Addition is: " + sum);
                            break;
                        }
                    case "-":
                        {
                            Console.Clear();
                            int subtarcat = 0;
                            Console.WriteLine("Enter the amount of Number you want to subtract: ");
                            int i = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Number: ");
                            subtarcat = Convert.ToInt32(Console.ReadLine());
                            for (int j = 1; j < i; j++)
                            {
                                Console.WriteLine("Enter Number: ");
                                int num1 = Convert.ToInt32(Console.ReadLine());
                              
                                subtarcat -= num1;
                            }

                            Console.WriteLine("Answer of Subtarction is: " + subtarcat);
                            break;
                        }
                    case "*":
                        {
                            Console.Clear();

                            Console.WriteLine("Enter the amount of Number you want to multiply: ");
                            int i = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Number: ");
                            float multiply = Convert.ToInt32(Console.ReadLine());

                            for (int j = 1; j < i; j++)
                            {
                                Console.WriteLine("Enter Number: ");
                                float num1 = float.Parse(Console.ReadLine());

                                multiply *= num1;
                            }

                            Console.WriteLine("Answer of Multiplication is: " + multiply);
                            break;
                        }
                    case "/":
                        {
                            Console.Clear();
                      
                            Console.WriteLine("Enter the amount of Number you want to divide : ");
                            int i = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Number: ");
                            float divide = Convert.ToInt32(Console.ReadLine());
                            
                            for (int j = 1; j < i; j++)
                            {
                                Console.WriteLine("Enter Number: ");
                                int num1 = Convert.ToInt32(Console.ReadLine());

                                divide /= num1;
                            }

                            Console.WriteLine("Answer of Division is: " + divide);
                            break;
                        }
                    case "s":
                        {
                            Console.Clear();
                            Double sqrt = 0d;

                            Console.WriteLine("Enter Number: ");
                            sqrt = Double.Parse(Console.ReadLine());

                            sqrt = Math.Sqrt(sqrt);

                            Console.WriteLine("Answer of Squre Root is: " + sqrt);

                            break;
                        }
                    case "%":
                        {
                            Console.Clear();
                            float mod = 0;

                            Console.WriteLine("Enter Number: ");
                            mod = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Number: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            mod %= num1;

                            Console.WriteLine("Answer of Modules is: " + mod);

                            break;
                        }
                    case "c":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Number: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Number: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            if (num1 > num2)
                            {
                                Console.WriteLine("Number " + num1 + " Is greater than Number " + num2);
                            }
                            else if (num1 < num2)
                            {
                                Console.WriteLine("Number " + num1 + " Is lesser than Number " + num2);
                            }
                            else
                            {
                                Console.WriteLine("Number " + num1 + " Is equal to Number " + num2);
                            }
                            break;
                        }
                    case "r":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Number: ");
                            double num = double.Parse(Console.ReadLine());

                            num = Math.Round(num);

                            Console.WriteLine("The rounded Number is: " + num);

                            break;
                        }
                    case "max":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Number: ");
                            int max = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Number: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            max = Math.Max(max, num2);

                            Console.WriteLine("The Maximum Number is: " + max);

                            break;
                        }
                    case "min":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Number: ");
                            int min = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Number: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            min = Math.Min(min, num2);

                            Console.WriteLine("The Minimum Number is: " + min);

                            break;
                        }
                    case "A":
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Radius of Circle: ");
                            float radius = float.Parse(Console.ReadLine());

                            float area = pi * (radius * radius);

                            Console.WriteLine("The area of circle is: " + area);
                            break;
                        }
                    case "0":
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Incorrect Input Enter Again");
                            break;
                        }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\tCaculator: ");
            Program obj = new Program();
            obj.menu();

        }
    }
}