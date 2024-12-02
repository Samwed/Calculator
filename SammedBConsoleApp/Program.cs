using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammedBConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Enter The num1 Value");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The num2 value");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose The Option");
            Console.WriteLine("\t a -  Adding");
            Console.WriteLine("\t b -  Substract");
            Console.WriteLine("\t c -  Multiply");
            Console.WriteLine("\t d -  Divide");



            //Using Switch statement
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("Addition :-> :{num1} + {num2} = " + (num1 + num2));
                    break;

                case "b":
                    Console.WriteLine("Substarction -> :{num1} - {num2} = " + (num1 - num2));
                    break;

                case "c":
                    Console.WriteLine("Multipication ->: {num1} *  {num2 } = " + (num1 * num2));
                    break;

                case "d":
                    Console.WriteLine("Divison -> {num1} / {num2} = " + (num1 / num2));
                    break;

            }
            
        }
    }
    }
