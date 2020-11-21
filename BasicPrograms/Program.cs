using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                 Console.WriteLine("Hello World!");
                Console.WriteLine("This is demo");
             }

            //if else statement
             Console.WriteLine("Enter a number:");
             int num = Convert.ToInt32(Console.ReadLine());

             if (num % 2 == 0)
             {
                 Console.WriteLine("It is even number");
             }
             else
             {
                 Console.WriteLine("It is odd number");
             }

            /*  //if statement
              int num = 11;
              if (num % 2 == 0)
              {
                  Console.WriteLine("even number");
              }
              else
              {
                  Console.WriteLine(" odd number");
              }*/
            //if else ladder
            /*Console.WriteLine("Enter a number to check grade:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 || num > 100)
            {
                Console.WriteLine("wrong number");
            }
            else if (num >= 0 && num < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (num >= 50 && num < 60)
            {
                Console.WriteLine("D Grade");
            }
            else if (num >= 60 && num < 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (num >= 70 && num < 80)
            {
                Console.WriteLine("B Grade");
            }
            else if (num >= 80 && num < 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (num >= 90 && num <= 100)
            {
                Console.WriteLine("A+ Grade");
            }*/

            /*            //while loop
                        int i = 1;
                        while (i <= 10)
                        {
                            Console.WriteLine(i);
                            i++;
                        }*/

            //do while
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);

        }
    }
}
