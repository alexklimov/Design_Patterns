using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
   public static  class Facade
    {
       static Subsystems.SubsystemA a = new Subsystems.SubsystemA();
       static Subsystems.SubsystemB b = new Subsystems.SubsystemB();
       static Subsystems.SubsystemC c = new Subsystems.SubsystemC();

        public static void Operation1()
        {
            Console.WriteLine("Операция 1\n" +
            a.A1() +
            a.A2() +
            b.B1());
        }
        public static void Operation2()
        {
            Console.WriteLine("Операция 2\n" +
            b.B1() +
            c.C1());
        }
    }
}
