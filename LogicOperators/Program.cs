using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
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
            //Ex6();
            //Ex7();
            //Ex8();
            //Ex9();
            //Ex11();
            //Ex12();
            Ex10();
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
            while (number == 0)
            {
                Console.Write("Podaj liczbę całkowitą: ");
                string result = Console.ReadLine();
                if (int.TryParse(result, out number))
                {
                    bool isEven = number % 2 == 0 ? true : false;

                    if (isEven)
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
                    if (number > 0)
                        Console.WriteLine($"{number} jest liczbą dodatnią");
                    else if (number < 0)
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
                    if (age > 0 && age < 18)
                    {
                        possiblePossition = "Jesteś za młody na dostępne stanowiska.";
                    }
                    else if (age >= 18 && age < 21)
                    {
                        possiblePossition = "Możesz zostać radnym.";
                    }
                    else if (age >= 21 && age < 30)
                    {
                        possiblePossition = "Możesz zostać posłem";
                        if (age >= 25)
                        {
                            possiblePossition += " oraz wójtem, burmistrzem i prezydentem miasta.";
                        }
                    }

                    else if (age >= 30 && age < 35)
                    {
                        possiblePossition = "Możesz zostać senatorem.";
                    }
                    else if (age >= 35)
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

        public static void Ex7()
        {
            /*
             * Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa
             */

            Console.Write("Podaj 3 liczby rozdzielone przecinkiem: ");
            string[] result = Console.ReadLine().Split(",");

            int a = int.Parse(result[0]);
            int b = int.Parse(result[1]);
            int c = int.Parse(result[2]);

            Console.WriteLine($"Największa liczba to: {Max(a, b, c)}");
            Console.WriteLine($"Najmniejsza liczba to: {Min(a, b, c)}");
        }

        public static int Max(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }

        public static int Min(int a, int b, int c)
        {
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }

        public static void Ex8()
        {
            /*
             * Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach
             */

            int mathResults = 80;
            int physicsResult = 71;
            int chemistryResult = 0;

            if (mathResults > 70 && physicsResult > 55 && chemistryResult > 45 && mathResults + physicsResult + chemistryResult > 180 ||
                mathResults + physicsResult > 150 || mathResults + chemistryResult > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
            }
        }

        public static void Ex9()
        {
            /*
             * Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach
             */
            Console.Write("Podaj temperaturę zewnątrzną [C] : ");
            double temp = double.Parse(Console.ReadLine());

            string result = (temp < 0) ? "cholernie piździ" :
                        (temp >= 0 && temp < 10) ? "Zimno" :
                        (temp >= 10 && temp < 20) ? "Chłodno" :
                        (temp >= 20 && temp < 30) ? "W sam raz" :
                        (temp >= 30 && temp < 40) ? "Zaczyna być słabo, bo gorąco" : "A weź wyprowadzam się na Alaskę.";

            Console.WriteLine(result);
        }

        public static void Ex11()
        {
            /*
             * Napisz program, który zmieni ocenę ucznia na jej opis
             */
           
            string gradeDescription = string.Empty;
            int grade = 0;

            while (grade <= 0 || grade > 6)
            {
                Console.WriteLine("Podaj ocenę aby zobczyc jej opis (1-6): ");
                string choice = Console.ReadLine();

                if (int.TryParse(choice, out grade) && !(grade > 6) && grade>0)
                {
                    gradeDescription = grade switch
                    {
                        1 => "Niedostateczny",
                        2 => "Dopuszczający",
                        3 => "Dostateczny",
                        4 => "Dobry",
                        5 => "Bardzo dobry",
                        6 => "Celujący",
                        _ => "Złe dane"
                    };
                }
                else
                {
                    Console.WriteLine("Podano nieprawidłową wartość. Spróbuj ponownie...");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }
            Console.WriteLine($"Ocena {grade} to {gradeDescription}");
        }

        public static void Ex12()
        {
            /*
             * Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę
             */
            int day = 0;
            WeekDay weekDay = WeekDay.Unassigned;

            while (day <= 0)
            {
                Console.Write("Enter the day of the week: ");
                string result = Console.ReadLine();
                day = int.Parse(result);

                if (Enum.IsDefined(typeof(WeekDay),day) && (day >0  && day <= 7))
                {
                    weekDay = (WeekDay)Enum.Parse(typeof(WeekDay), result);
                    Console.WriteLine($"\nDay {day} is {weekDay}");
                }
                else
                {
                    day = 0;
                    Console.WriteLine("Podano nieprawidłową wartość. Spróbuj ponownie...");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }
            
        }

        public static void Ex10()
        {
            /*
             * Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt
             */
        }

    }
}
