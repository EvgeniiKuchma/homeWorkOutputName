using System;

namespace homeWorkOutputName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputUserName;
            char inputUserSimbol;

            Console.Write("Enter the desired name: ");
            inputUserName = Console.ReadLine();
            Console.Write("Enter the desired simbol: ");
            inputUserSimbol = Convert.ToChar(Console.ReadLine());

            string nameSimbol = ($"{inputUserSimbol}{inputUserName}{inputUserSimbol}");
            string simbolString = string.Empty;

            for (int i = 0; i < nameSimbol.Length; i++)
            {
                simbolString += inputUserSimbol;
            }

            Console.WriteLine(simbolString);
            Console.WriteLine(nameSimbol);
            Console.WriteLine(simbolString);
        }
    }
}
