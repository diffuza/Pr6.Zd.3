using System;
using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int x = 0;
            int y = 0;
            int z = 0;
            Console.WriteLine("Введите 3 числа");
            Console.Write("x= ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("y= ");
            y = Convert.ToInt16(Console.ReadLine());
            Console.Write("z= ");
            z = Convert.ToInt16(Console.ReadLine());
            k = Math.Abs(x - y - z);
            Console.WriteLine("Результат вычисления :{0}", k);

        }
    }
}
