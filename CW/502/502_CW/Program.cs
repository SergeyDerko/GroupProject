using System;
using System.Collections.Generic;
using System.Linq;
using _04_Array;

namespace _502_CW
{
    class Program
    {
        enum MyEnum
        {
            Black,
            DarkBlue = 200,
            DarkGreen,
            DarkCyan,
            DarkRed =300
        }
        static void Main(string[] args)
        {
            //FirstSample();
            var stack = new Stack<User>();
            stack.Push(new User());
            stack.Push(new User());
            stack.Push(new User());
            stack.Push(new User());
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

        }

    }
}