using System;

namespace Static_Members_Lumpkin_Dalton
{
    class Program
    {
        static void Main(string[] args)
        {
            //using the float thang
            Console.WriteLine(Calculate.Add(1.3f, 4.5f));
            Console.WriteLine(Calculate.Subtract(1.3f, 4.5f));
            Console.WriteLine(Calculate.Multiply(1.3f, 4.5f));
            Console.WriteLine(Calculate.Divide(1.3f, 4.5f));

            //using the int thang
            Console.WriteLine(Calculate.Add(1f, 4f));
            Console.WriteLine(Calculate.Subtract(1f, 4f));
            Console.WriteLine(Calculate.Multiply(1f, 4f));
            Console.WriteLine(Calculate.Divide(1f, 4f));
        }
    }
}
