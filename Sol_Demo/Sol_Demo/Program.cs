using System;

namespace Sol_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Demo demo = new Demo();

            // C# before 6
            int value = 0;
            demo.OutDemo(out value);
            Console.WriteLine(value); // 11

            // in C# 7.0
            demo.OutDemo(out int myValue);
            Console.WriteLine(myValue);// 11

            demo.OutDemo(out var myVarValue);
            Console.WriteLine(myVarValue);// 11

            

        }
    }

    public class Demo
    {
        public void OutDemo(out int value)
        {
            value = 11;
        }
    }
}
