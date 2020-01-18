using System;
using System.Collections;
using System.Collections.Generic;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Stack<char> stackChars = new Stack<char>(inputString);
            while (stackChars.Count > 0)
            {
                Console.Write(stackChars.Pop());
            }
            Console.WriteLine();

            Console.WriteLine("result");
        }
    }
}
