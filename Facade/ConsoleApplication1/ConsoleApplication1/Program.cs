using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           //клиентский код
            Facade.Operation1();
            Facade.Operation2();

            // Wait for user
            Console.Read();

        }
    }
}
