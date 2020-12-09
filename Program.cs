using System;
using System.Linq;
using System.Collections.Generic;

namespace _11.LambdaExpresion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {0, 5, 6, 0, 8, 9, 11 };
            Console.WriteLine(array.Count()); // count in this case is equal to Length
            Console.WriteLine(array.Length); // count provides more functionality, we want to count special numbers on given  rule !
            Console.WriteLine(array.Count(x => x > 2)); //take the number of elements that are > 2 ;We have 5 numbers > 2 into our collection
            Console.WriteLine(array.Count(x => x != 0)); //count each element that is different than 0 ;We have  5 elements
            // if we supply lambda expression into count() the method will count only the elements complying with Lambda rule-condition;
        }
    }
}
