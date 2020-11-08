using System;

namespace LogicOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ex1();
        }
        public static void Ex1()
        {
            int firstNubmer = 5;
            int secondNumber = 5;

            Console.WriteLine($"{firstNubmer} == {secondNumber} ? : {firstNubmer == secondNumber}");
        }
    }
}
