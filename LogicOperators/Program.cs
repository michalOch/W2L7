using System;
using System.Runtime.Serialization;
using System.Threading;

namespace LogicOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            Ex6();
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

        public static void Ex3()
        {
            /*
             * Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
             */

            int number = 0;
            while (number == 0)
            {
                Console.Write("Podaj liczbę całkowitą: ");
                string result = Console.ReadLine();
                if (int.TryParse(result, out number))
                {
                    if(number > 0)
                        Console.WriteLine($"{number} jest liczbą dodatnią");
                    else if(number < 0)
                        Console.WriteLine($"{number} jest liczbą ujemną");
                    else
                        Console.WriteLine($" Podana liczba jest równa 0");
                }
                else
                {
                    Console.WriteLine("Podano nieprawidłową liczbę");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }
        }

        public static void Ex4()
        {
            /*
             * Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
             */
            int year = 0;
            while (year == 0)
            {
                Console.Write("Podaj rok (RRRR): ");
                string result = Console.ReadLine();

                if (int.TryParse(result, out year))
                {
                    if (isLeapYear(year))
                        Console.WriteLine($"{year} jest rokiem przestępnym");
                    else
                        Console.WriteLine($"{year} nie jest rokiem przestępnym");
                }
                else
                {
                    Console.WriteLine("Podano nieprawidłową wartość. Spróbuj ponownie...");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }
        }

        public static bool isLeapYear(int year)
        {
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        }

        public static void Ex5()
        {
            /*
             * Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta.
             */

            int age = 0;
            while (age == 0 || age < 0)
            {
                Console.Write("Podaj wiek kandytana (liczba całkowita > 0): ");
                string result = Console.ReadLine();
                string possiblePossition = string.Empty;
                if (int.TryParse(result, out age) && age > 0)
                {
                    if(age > 0 && age < 18)
                    {
                        possiblePossition = "Jesteś za młody na dostępne stanowiska.";
                    }
                    else if(age >= 18 && age < 21)
                    {
                        possiblePossition = "Możesz zostać radnym.";
                    }
                    else if (age >= 21 && age < 30)
                    {
                        possiblePossition = "Możesz zostać posłem";
                        if(age >= 25)
                        {
                            possiblePossition += " oraz wójtem, burmistrzem i prezydentem miasta.";
                        }
                    }
   
                    else if(age >= 30 && age < 35)
                    {
                        possiblePossition = "Możesz zostać senatorem.";
                    }
                    else if( age >= 35)
                    {
                        possiblePossition = "Możesz zostać prezydentem.";
                    }

                    Console.WriteLine(possiblePossition);
                }

                else
                {
                    Console.WriteLine("Podano nieprawidłową wartość. Spróbuj ponownie...");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }
        }


        public static void Ex6()
        {
            /*
             * Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu
             */
            double userHeight = 0;
            while (userHeight <= 0)
            {
                Console.Write("Podaj wzrost użytkownika (cm): ");
                string result = Console.ReadLine();
                string userDescription = string.Empty;

                if (double.TryParse(result, out userHeight) && userHeight > 0)
                {
                    userDescription = (userHeight <= 140) ? "Jesteś krasnoludem." :
                        (userHeight > 140 && userHeight <= 165) ? "Jesteś niski." :
                        (userHeight > 165 && userHeight <= 175) ? "Średni wzrost." :
                        (userHeight > 175 && userHeight <= 190) ? "Trzeba przyznać jesteś wysoki." :
                        "Jesteś olbrzymem.";

                    Console.WriteLine(userDescription);
                }

                else
                {
                    Console.WriteLine("Podano nieprawidłową wartość. Spróbuj ponownie...");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }

        }
    }
}
