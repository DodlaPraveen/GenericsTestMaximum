using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumProblemUsingGenerics
{

    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }

}
