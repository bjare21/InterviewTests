using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<string> tree2 = new Tree<string>("Mortal Kombat");
            tree2.Insert("Defender Of Crown");
            tree2.Insert("Gobliins");
            tree2.Insert("Settlers");
            tree2.Insert("Dune 2");
            tree2.Insert("Mentor");
            tree2.Insert("Franko");
            tree2.Insert("Doman");
            tree2.Insert("Legion");
            tree2.Insert("Misja Harolda");
            tree2.Insert("Eksperyment Deflin");
            tree2.Insert("Mortal Kombat 2");
            tree2.Insert("Shadow of the Beast");
            tree2.Insert("Lost Patrol");
            tree2.Insert("Monkey Island");
            tree2.Insert("Pinbal Fantasies");
            tree2.Insert("Genghis Khan");
            tree2.Insert("The Lost Vikings");
            tree2.Insert("Master Blaster");
            tree2.Insert("Ciemna Strona");
            tree2.Insert("Another World");
            tree2.Insert("Flashback");
            tree2.Insert("Lemmings");
            tree2.Insert("Blitz Bommbers");
            tree2.Insert("Deluxe Galaga");
            tree2.WalkTree();
            Console.ReadKey();


            Console.WriteLine("Hello World!");
        }
    }



    class Cuboid:IComparable, IComparable<Cuboid>
    {
        public Cuboid(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int Volume()
        {
            return a * b * c;
        }

        public int CompareTo(object obj)
        {
            Cuboid cu2 = obj as Cuboid;
            if (this.Volume() == cu2.Volume()) return 0;
            if (this.Volume() > cu2.Volume()) return 1;
            return -1;
        }

        public int CompareTo(Cuboid cuboid)
        {
            if (this.Volume() == cuboid.Volume()) return 0;
            if (this.Volume() > cuboid.Volume()) return 1;
            return -1;
        }

        private int a, b, c;
    }
}
