using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var NumbersList = new ArrayList();
            NumbersList.Add(10);
            NumbersList.Add(20);
            NumbersList.Add(30);
            NumbersList.Add(50);
            NumbersList.Add(40);
            NumbersList.Add(100);
            NumbersList.Add(60);

            Console.WriteLine("Total items : " + NumbersList.Count);
            Console.WriteLine("Current Capacity : " + NumbersList.Capacity);

            NumbersList.Remove(20);
            Console.WriteLine("Total items after removing 20 : " + NumbersList.Count);

            foreach (object item in NumbersList)
            {
                Console.WriteLine(item.ToString());
            }

            NumbersList.Sort();
            Console.WriteLine("Items after sort");
            foreach (object item in NumbersList)
            {
                Console.WriteLine(item.ToString());
            }

            int index = NumbersList.BinarySearch(40);
            if (index >= 0)
            {
                Console.WriteLine("Value {0} found at index : {1}", NumbersList[index], index);
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.ReadKey();
        }
    }
}
