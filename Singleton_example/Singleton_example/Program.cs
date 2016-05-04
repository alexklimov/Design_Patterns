using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton_example
{
    /// <summary>
    /// date : 04.05.2016 
    /// name: Alexander Klimov
    /// example of pattern Singleton
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);

            //не сработает, так как объект уже создан    
            comp.OS = OperationSytem.getInstance("Windows 10");
            Console.WriteLine(comp.OS.Name);

            Console.ReadLine();
        }
    }

    class Computer
    {
        public OperationSytem OS { get; set; }
        public void Launch(string osName)
        {
            OS = OperationSytem.getInstance(osName);
        }
    }
    class OperationSytem
    {
     private static OperationSytem instance;
 
    public string Name { get; private set; }

    protected OperationSytem(string name)
    {
        this.Name=name;
    }

    public static OperationSytem getInstance(string name)
    {
        if (instance == null)
            instance = new OperationSytem(name);
        return instance;
    }
    }
}
