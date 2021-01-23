using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {2,8,14,7};
            list.Add(5);

            int length = list.Count;

            foreach (var value in list)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine($"\nLength of array: {length}");

            Console.WriteLine("********** MY LİST **********");

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Emre");
            isimler.Add("Can");
            foreach (var value in isimler.mylist)
            {
                Console.Write(value + " - ");
            }

            Console.WriteLine($"\nLength of array: {isimler.Count}");

            Console.ReadKey();
        }
    }
}
