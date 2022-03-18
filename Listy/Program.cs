using System;

namespace Listy
{
    class Program
    {
        static void Main(string[] args)
        {
            TableList list = new TableList();

            list.PushFront(21);
            list.PushFront(5);
            list.PushFront(13);
            list.PushFront(8);

            Console.WriteLine("Czy lista jest pusta? {0}", list.IsEmpty() ? "Tak" : "Nie");

            Console.WriteLine("Ostatni element listy to: {0}", list.Back());
            Console.WriteLine("Usuwamy 4 element i...");
            list.Erase(4);
            Console.WriteLine("Ostatni element listy to: {0}", list.Back());
        }
    }
}
