using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_application
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //String str;
            //int num = 0;
            //do
            //{
            //    str = Console.ReadLine();
            //    if (str == " ")
            //    {
            //        num++;
            //    }
            //} while (str != ".");
            //Console.WriteLine("number of spaces = " + num);

            // 2
            //Console.WriteLine("Enter the ticket number");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 999999 && number < 100000)
            //{
            //    Console.WriteLine("Error");
            //}
            //else
            //{
            //    int count1 = number % 10;
            //    int count2 = (number % 100) / 10;
            //    int count3 = (number % 1000) / 100;
            //    int count4 = (number % 10000) / 1000;
            //    int count5 = (number % 100000) / 10000;
            //    int count6 = (number % 1000000) / 100000;
            //    if ((count1 + count2 + count3) == (count4 + count5 + count6))
            //    {
            //        Console.WriteLine("this ticket is lucki");
            //    }
            //    else
            //    {
            //        Console.WriteLine("this ticket is not lucki");
            //    }
            //}

            // 3
            //int a = 1;
            //int b = 9;
            //for (int i = a; i <= b; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}

            // 4
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                string number2 = number.ToString();
                char[] inputarray = number2.ToCharArray();
                Array.Reverse(inputarray);
                number2 = new string(inputarray);
                Console.WriteLine(number2);
            }

        }
    }
}
