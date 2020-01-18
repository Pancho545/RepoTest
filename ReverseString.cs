using System;
using System.Collections;
using System.Collections.Generic;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stackChars = new Stack<char>(input);
            while (stackChars.Count > 0)
            {
                Console.Write(stackChars.Pop());
            }
            Console.WriteLine();
        }
    }
}
