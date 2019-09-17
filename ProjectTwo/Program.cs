using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void PrintLinkedList()
        {
            LinkedList<int> intList = new LinkedList<int>();
            {
                intList.AddLast(1);
                intList.AddLast(1);
                intList.AddLast(1);
                intList.AddLast(1);
                intList.AddLast(1);
                foreach (int val in intList)
                {
                    Console.WriteLine(val);
                }

            }
        }

        public void List()
        {
            List<int> intList = new List<int>();
            {
                intList.Remove(1);
                intList.Remove(1);
                intList.Remove(1);
                intList.Remove(1);
                intList.Remove(1);
                foreach (int val in intList)
                {
                    Console.WriteLine(val);
                }

            }
        }

        public void Queue()
        {
            Queue<int> intList = new Queue<int>();
            {
                intList.Enqueue(1);
                intList.Enqueue(1);
                intList.Enqueue(1);
                intList.Enqueue(1);
                intList.Enqueue(1);
                foreach (int val in intList)
                {
                    Console.WriteLine(val);
                }

            }
        }

        public void Stack()
        {
            Stack<int> intList = new Stack<int>();
            {
                intList.Push(1);
                intList.Push(1);
                intList.Push(1);
                intList.Push(1);
                intList.Push(1);
                foreach (int val in intList)
                {
                    Console.WriteLine(val);
                }

            }
        }

        public void Dictionary()
        {
            Dictionary<string, int> ages = new Dictionary<string, int>();
            {
                ages.Add("Kenya", 1);
                ages.Add("Kenya", 2);
                ages.Add("Kenya", 3);
                ages.Add("Kenya", 4);
                ages.Add("Kenya", 5);
                foreach (KeyValuePair<string, int> element in ages)
                {
                    Console.WriteLine(ages);
                }

            }
        }

        public void SortedList()
        {
            Dictionary<string, int> ages = new Dictionary<string, int>();
            {
                ages.Add("Kenya", 1);
                ages.Add("Kenya", 2);
                ages.Add("Kenya", 3);
                ages.Add("Kenya", 4);
                ages.Add("Kenya", 5);
                foreach (KeyValuePair<string, int> element in ages)
                {
                    Console.WriteLine(ages);
                }





            }
        }
    }
}