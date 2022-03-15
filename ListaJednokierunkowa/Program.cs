using System;

namespace ListaJednokierunkowa
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            if (list.IsClear()) Console.WriteLine("Lista jest pusta.");
            list.Add(5);
            list.Add(21);
            list.Add(13);
            list.Add(78);
            list.Add(112);
            list.Add(13);
            list.Add(63);
            list.Add(2);
            list.Add(101);
            list.Add(67);
            list.Add(1);
            list.Add(63);
            list.Add(14);
            list.Add(13);
            list.Add(121);

            Console.WriteLine("Liczba elementów listy: {0}. Pusta ? Odpowiedź: {1}", list.Count, list.IsClear());
            list.Display();


            Console.WriteLine("Próba usunięcia z listy indeksu [rozmiar +1]. Rozmiar = {0}", list.Count);
            if (list.Delete(list.Count + 1)) Console.WriteLine("Pomyślnie usunięto element z listy.");
            else Console.WriteLine("Błędny indeks");

            if (list.Delete(1)) Console.WriteLine("Usunięto pierwszy element listy.");
            list.Display();

            if (list.Delete(list.Count)) Console.WriteLine("Usunięto ostatni elemnt listy.");
            list.Display();

            int ndx = list.Count / 2;
            if (list.Delete(ndx)) Console.WriteLine("Usunięto {0} element listy.", ndx);
            list.Display();

            Console.WriteLine("Usuwamy duplikaty.");
            list.RemoveDuplicates();
            list.Display();

            Console.WriteLine("Maksymalna wartość:");
            Console.WriteLine(list.Max().Value);

            Console.WriteLine("Odwróć listę");
            list.Reverse();

            list.Display();
        }
    }


    class List
    {
        private Element root;
        private int count;

        public List()
        {
            this.root = null;
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(int value)
        {
            if (this.root == null)
            {
                this.root = new Element(value);
            }
            else
            {
                Element tmp = this.root;
                while (tmp.Next != null) tmp = tmp.Next;
                tmp.SetNext(value);
            }

            ++count;
        }


        public bool IsClear()
        {
            return count == 0 ? true : false;
        }

        public bool Delete(int index)
        {
            if ((index < 1) || (index > count)) return false;

            if ((index == 1)) root = root.Next;

            else if (index == count)
            {
                Element tmp = root;
                while (tmp.Next.Next != null) tmp = tmp.Next;
                tmp.DeleteNext();
            }
            else
            {
                Element tmp = this.root;
                for (int i = 1; i < index; ++i) tmp = tmp.Next;
                tmp.ChangeNext();
            }
            --count;
            return true;
        }

        public Element Max()
        {
            Element pMax = this.root;
            if (pMax == null) return new Element(0);

            Element p = pMax.Next;
            while (p != null)
            {
                if (p.Value > pMax.Value) pMax = p;
                p = p.Next;
            }

            return pMax;
        }

        public void RemoveDuplicates()
        {
            if (this.count <= 1) return;

            Element tmp = this.root;
            while (tmp != null)
            {
                Element curr = tmp;
                while (curr.Next != null)
                {
                    if(curr.Next.Value == tmp.Value)
                    {
                        curr.ChangeNext();
                    }
                    if(curr.Next!=null) curr = curr.Next;
                }
                tmp = tmp.Next;
            }
        }

        public void Reverse()
        {
            if (this.root == null) return;
            Element pc = this.root;
            int i = 0;
            while (pc.Next != null)
            {
                Console.Write("\nOdwracanie, krok: {0}, [pc] = {1}, [pc.Next] = {2}", ++i, pc.Value, pc.Next.Value);

                Element p = pc.Next;
                Console.Write(" [p] = {0}", p.Value);
                pc.Next = p.Next;
                Console.Write(" [pc.Next] = {0}", pc.Next!=null?pc.Next.Value:"-");
                p.Next = this.root;
                Console.Write(" [p.Next] = {0}", p.Next.Value);
                this.root = p;
                Console.Write(" [this.root] = {0}", this.root.Value);
                
            }
        }

        public void Display()
        {
            Element tmp = this.root;
            for (int i=1; tmp != null; ++i)
            {
                Console.WriteLine("Element {0} listy = {1}.", i, tmp.Value);
                tmp = tmp.Next;
            }
        }

    }

    class Element
    {
        private int value;
        private Element next;

        public Element(int value)
        {
            this.value = value;
            this.next = null;
        }

        public int Value
        {
            get
            {
                return this.value;
            }
        }

        public Element Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }

        public void SetNext(int value)
        {
            this.next = new Element(value);
        }

        public void DeleteNext()
        {
            this.next = null;
        }

        public void ChangeNext()
        {
            this.next = Next.Next != null ? Next.Next : null;
        }
    }
}
