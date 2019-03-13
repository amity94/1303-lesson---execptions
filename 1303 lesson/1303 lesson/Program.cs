using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1303_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = b = 0;
            try
            {
                int c = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("infinity");
            }
            finally
            {
                Console.WriteLine("worked");
            }

            bool completed = false;
            do
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    completed = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("wrong int!");
                }
            } while (completed == false);
            try
            {
                SayMyName("amity", 1);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void SayMyName(string name, int age)
        {
            if(age<0)
            {
                throw new ArgumentException("specify the age");
            }
            else
            {
                Console.WriteLine(name + " " + age);
            }
        }
    }
}
