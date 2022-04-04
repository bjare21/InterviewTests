using System;
using System.Linq;

namespace Listy
{
    class Program
    {
        static void Main(string[] args)
        {
            //TableList list = new TableList();

            //list.PushFront(21);
            //list.PushFront(5);
            //list.PushFront(13);
            //list.PushFront(8);

            //Console.WriteLine("Czy lista jest pusta? {0}", list.IsEmpty() ? "Tak" : "Nie");

            //Console.WriteLine("Ostatni element listy to: {0}", list.Back());
            //Console.WriteLine("Usuwamy 4 element i...");
            //list.Erase(4);
            //Console.WriteLine("Ostatni element listy to: {0}", list.Back());

            List lista = new List();

            Console.WriteLine("Czy lista jest pusta? {0}", lista.IsEmpty());
            Console.WriteLine("Dodajemy element na początku listy...");
            lista.PushFront(21);
            Console.WriteLine("Czy teraz lista jest pusta? {0}", lista.IsEmpty());
            Console.WriteLine("Wartość pierwszego elementu listy = {0}," +
                " ostatniego = {1}", lista.Front(), lista.Back());

            int min = 1;
            int max = 20;

            Random random = new Random();

            int[] tab = Enumerable
                .Repeat(0, 21)
                .Select(i => random.Next(min, max))
                .ToArray();
            PrintTable(tab); 
            SortList.SelectionSort(tab, 21);
            PrintTable(tab);
        }

        private static void PrintTable(int[] tab)
        {
            Console.WriteLine("----");
            foreach(int i in tab)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----");
        }
    }
}
