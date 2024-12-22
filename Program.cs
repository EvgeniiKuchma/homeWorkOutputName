using System;

namespace homeWorkOutputName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberString = 3;
            int sizeNumberSimbol = 2;
            string inputUserName;
            char inputUserSimbol;

            Console.Write("Enter the desired name: ");
            inputUserName = Console.ReadLine();
            Console.Write("Enter the desired simbol: ");
            inputUserSimbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < numberString; i++)
            {
                if (i == numberString - sizeNumberSimbol)
                {
                    Console.WriteLine($"{inputUserSimbol}{inputUserName}{inputUserSimbol}");
                    continue;
                }
                for (int j = 0; j < inputUserName.Length + sizeNumberSimbol; j++)
                {
                    Console.Write(inputUserSimbol);

                    if (j == inputUserName.Length + 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
