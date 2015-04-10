using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSnippets
{
    class Program
    {
        static string RunExtensions()
        {
            return "todo";
        }
        static void Main(string[] args)
        {
            List<int> list = Enumerable.Range(1, 10).ToList<int>();
            List<int> list1 = Enumerable.Range(8, 17).ToList<int>();

            int oddIndex = list.FindIndex(x => x % 2 != 0);

            List<string> list2 = new List<string>() { "Sleeves", "Shorts", "Hats"};

            string upper = "geronimo";
            upper = upper.UpperCaseFirstCharacter();

            var result = list2.Select(x => x.ToUpper());

            var intersect = list.Intersect(list1); //gets matches in both collections

            foreach (int value in intersect)
            {
                Console.WriteLine(value);
            }
           
            Console.Read();
        }
    }
}
