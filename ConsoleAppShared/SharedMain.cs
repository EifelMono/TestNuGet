using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class MainShared
    {
        public static void Run()
        {
            Console.WriteLine(nameof(ConsoleApp));
            var x = new HelloWorldClass();

            Console.ReadLine();
        }
    }
}
