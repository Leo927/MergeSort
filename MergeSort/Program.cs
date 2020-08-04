using System;
using System.Collections.Generic;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.WriteLine("please enter the amount of number to generate");
            int count = Convert.ToInt32( Console.ReadLine());
            List<IComparable> unsortedList = new List<IComparable>(count);
            Console.WriteLine("The following is the sorted list");
            for (int i = 0; i < count; i++)
            {
                unsortedList.Add(rng.Next());
            }
            MergeSort.Sort(unsortedList)
                .ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
