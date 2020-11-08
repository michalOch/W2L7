using System;
using System.Threading;

namespace LogicOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ex1();
            Ex2();
        }
        public static void Ex1()
        {
            /*
             * Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
             */

            int firstNubmer = 5;
            int secondNumber = 5;
            Console.WriteLine($"{firstNubmer} == {secondNumber} ? : {firstNubmer == secondNumber}");
        }
        public static void Ex2()
        {
            /*
             * Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
             */

            int number = 0;
            while(number == 0)
            {
                Console.Write("Podaj liczbę całkowitą: ");
                string result = Console.ReadLine();
                if(int.TryParse(result, out number))
                {
                    bool isEven = number % 2 == 0 ? true : false;

                    if(isEven)
                        Console.WriteLine($"{number} jest liczbą parzystą");
                    else
                        Console.WriteLine($"{number} jest liczbą nieparzystą");
                }
                else
                {
                    Console.WriteLine("Podano nieprawidłową liczbę");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }
            
        }
    }
}
