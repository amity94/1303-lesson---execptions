﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1303
{
    class Program
    {
        static void Main(string[] args)
        {
            MyProtectedUniqueList words = new MyProtectedUniqueList("hello");

            words.Add("hello");
            try
            {
                words.Add("hello");
            }
            catch (StringAlreadyExsitsException e)
            {
                Console.WriteLine(e.Message);
            }
          
            try
            {
                words.Add("");
            }
            catch (StringEmptyException e)
            {
                Console.WriteLine(e.Message);
            }

            words.Add("world, ");
            words.Add("how");
            words.Add("are");
            words.Add("you?");

            foreach (var word in words)
                Console.WriteLine(word);

            words.Remove("are");
            foreach (var word in words)
                Console.WriteLine(word);
            try
            {
                words.Remove("your");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            words.RemoveAt(2);
            foreach (var word in words)
                Console.WriteLine(word);

            try
            {
                words.RemoveAt(5);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                words.Clear("pass");
            }
            catch (WrongPasswordException e)
            {
                Console.WriteLine(e.Message);
            }

            //words.Clear("hello");
            //foreach (var word in words)
            //    Console.WriteLine(word);

            words.Add("one");
            words.Add("two");
            words.Add("aaaaa");

            try
            {
                words.Sort("hio");
            }
            catch(WrongPasswordException e)
            {
                Console.WriteLine(e.Message);
            }

            words.Sort("hello");
            foreach (var word in words)
                Console.WriteLine(word);
            Console.WriteLine("======================");
            
            Trial(null);

            Console.WriteLine(words);


            MyProtectedUniqueList list = new MyProtectedUniqueList("hi");

            list.Add("hello");
            list.Add("C#");
            list.Add(".NET");
            list.Add("Bye");
            Console.WriteLine(list);

            throw new newexception();
            throw new newexception2();

        }
        static void Trial(string word)
        {
            MyProtectedUniqueList words = new MyProtectedUniqueList("hello");
            try
            {
                words.Add(word);
            }
            catch (StringEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
