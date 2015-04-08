using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSnippets
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list1 = new List<int>() { 1, 5, 6, 7 };
            int oddIndex = list.FindIndex(x => x % 2 != 0);

            List<string> list2 = new List<string>() { "Sleeves", "Shorts", "Hats"};

            var result = list2.Select(x => x.ToUpper());

            var intersect = list.Intersect(list1); //gets matches in oth collections

            foreach (int value in intersect)
            {
                Console.WriteLine(value);
            }
           
            Console.Read();
        }
    }
}
