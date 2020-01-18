using System;
using System.Collections;
using System.Collections.Generic;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            Stack<char> stackChars = new Stack<char>(inputString);
            Console.Write("Reverse string: ");
            while (stackChars.Count > 0)
            {
                Console.Write(stackChars.Pop());
            }
            Console.WriteLine();
        }
    }
}
