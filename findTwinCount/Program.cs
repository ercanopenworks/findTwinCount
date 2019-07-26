using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findTwinCount
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = {1,1,1,3,4,9,3,2,4,4,2};
            int n = 8;

            //HashSet<int> set = new HashSet<int>();
            //int count = 0;
            //for (int i=0; i<numbers.Count();i++)
            //{
            //    int element = numbers[i];
            //    if (set.Contains(element))
            //    {
            //        set.Remove(element);
            //        count++;
            //    }
            //    else
            //    {
            //        set.Add(element);
            //    }
            //}


            List<int> set = new List<int>();
            int count = 0;
            for (int i = 0; i < numbers.Count(); i++)
            {
                int element = numbers[i];
                if (set.Contains(element))
                {
                    set.Remove(element);
                    count++;
                }
                else
                {
                    set.Add(element);
                }
            }

            for (int i = 0; i < set.Count; i++)
            {
                Console.WriteLine(set[i]);
            }
            Console.WriteLine("----");
            Console.WriteLine(count.ToString());
            Console.ReadLine();

            
        }
    }
}
