using System;

namespace Hansi_eded_boyukdur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte X = 22;

            //byte Y = 25;

            //byte Z = 20;

            byte X = Convert.ToByte(Console.ReadLine());

            byte Y = Convert.ToByte(Console.ReadLine());

            byte Z = Convert.ToByte(Console.ReadLine());

            if (X>Y && X>Z)
            {
                Console.WriteLine(X);
            }
            else if (Y>X && Y>Z)
            {
                Console.WriteLine(Y);
            }
            else if (Z>X && Z >Y)
            {
                Console.WriteLine(Z);
            }
        }
    }
}
