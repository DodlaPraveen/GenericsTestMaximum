using System;

namespace FindMaximumProblemUsingGenerics
{
    public class Program
    {
        public static void Main()
        {
            Printer printer = new Printer();
            printer.Print<int>(100);
            printer.Print(200); // type infer from the specified value
            printer.Print<string>("Hello");
            printer.Print("World!"); // type infer from the specified value
            Console.ReadLine();
        }

    }
}
