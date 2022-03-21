using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy
{
    public class List
    {
        private int value;
        private Element element;
        //ogon i głowa - sztuczne elementy oznaczające koniec i początek listy.
        private Element head, tail;

        public List()
        {
            head = new Element();
            tail = new Element();

            //ustawienie "wskaźników" dla głowy i ogona
            head.Previous = null;
            head.Next = tail;
            tail.Previous = head;
            tail.Next = null;
        }

        /// <summary>
        /// Zwraca wartość wskazanego elementu.
        /// </summary>
        /// <param name="element">Element, którego wartość zwrócić.</param>
        /// <returns>Wartość wskazanego elementu.</returns>
        public int ValueAt(Element element)
        {
            return element.Value;
        }

        /// <summary>
        /// Zwraca następny element względem przekazanego elementu.
        /// </summary>
        /// <param name="element">Element dla którego następnego elementu szukamy.</param>
        /// <returns>Następny element na liście.</returns>
        public Element Next(Element element)
        {
            return element.Next;
        }

        /// <summary>
        /// Zwraca ostatni element na liście.
        /// </summary>
        /// <returns>Ostatni element listy.</returns>
        public Element Last()
        {
            return tail.Previous;
        }

        /// <summary>
        /// Zwraca pierwszy element na liście.
        /// </summary>
        /// <returns>Pierwszy element na liście.</returns>
        public Element First()
        {
            return head.Next;
        }

        /// <summary>
        /// Usuwa z listy wskazany element.
        /// </summary>
        /// <param name="element">Element, który należy usunąć z listy.</param>
        public void Erase(Element element)
        {
            element.Previous.Next = element.Next;
            element.Next.Previous = element.Previous;
        }

        /// <summary>
        /// Wstawianie wartości w miejscu wskazanego elementu.
        /// </summary>
        /// <param name="position">Element w którego miejscu wstawiamy wartość.</param>
        /// <param name="value">Wartość do wstawienia.</param>
        public void Insert(Element position, int value)
        {
            //Element pomocniczy zostaje utworzony i przypisana mu zostaje wartość.
            Element pom = new Element();
            pom.Value = value;

            //Przepinanie wskaźników.
            pom.Previous = position.Previous;   
            pom.Next = position;
            position.Previous.Next = pom;
            position.Previous = pom;
        }

        /// <summary>
        /// Usuwa ostatni element listy.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public void PopBack()
        {
            if (IsEmpty()) throw new ArgumentNullException("tail.Previous", "Wartość elementu, którą próbowano pobrać jest null.");

            Element pom = tail.Previous;
            tail.Previous = pom.Previous;   // [nowy ostatni] <- [ogon]
            pom.Previous.Next = tail;       // [nowy ostatni] -> [ogon]
        }

        /// <summary>
        /// Usuń pierwszy element listy.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public void PopFront()
        {
            if (IsEmpty()) throw new ArgumentNullException("head.Next", "Wartość elementu który próbowano pobrać jest null.");

            Element pom = head.Next;
            head.Next = pom.Next;       //[glowa] -> [nowy pierwszy]
            head.Next.Previous = head;  //[glow] <- [nowy pierwszy]
        }

        /// <summary>
        /// Wstawia wartość na końcu listy.
        /// </summary>
        /// <param name="value">Wartość do wstawienia na końcu listy.</param>
        public void PushBack(int value)
        {
            //Utworzenie elementu pomocniczego i przypisanie wartości.
            Element pom = new Element();
            pom.Value = value;

            //Przepinanie wskaźników.
            pom.Previous = tail.Previous;   // [stary ostatni] <- [nowy ostatni]
            pom.Next = tail;                // [nowy ostatni] -> [ogon]
            tail.Previous.Next = pom;       // [stary ostani] -> [nowy ostatni]
            tail.Previous = pom;            // [nowy ostatni] <- [ogon]
        }

        /// <summary>
        /// Wstawia wartość na początku listy.
        /// </summary>
        /// <param name="value">Wartość do wstawienia na początku listy.</param>
        public void PushFront(int value)
        {
            //Utworzenie zmiennej pomocniczej i przypisanie wartości.
            Element pom = new Element();     
            pom.Value = value;              

            //Przepinanie wskźników
            pom.Next = head.Next;       // [nowy pierwszy] -> [stary pierwszy]          
            pom.Previous = head;        // [head] <- [nowy pierwszy]
            head.Next.Previous = pom;   // [nowy pierwszy] <- [stary pierwszy]
            head.Next = pom;            // [head] -> [nowy pierwszy]
        }

        /// <summary>
        /// Zwraca wartość ostatniego elementu listy.
        /// </summary>
        /// <returns>Wartość ostatniego elementu listy.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Back()
        {
            if (!IsEmpty()) return tail.Previous.Value;

            throw new ArgumentNullException("tail.Previous", "Wartość elementu, którą próbowano pobrać jest null.");
        }

        /// <summary>
        /// Zwraca wartość pierwszego elementu listy.
        /// </summary>
        /// <returns>Wartość pierwszego elementu listy.</returns>
        /// <exception cref="ArgumentNullException">W razie, gdy lista jest pusta wyrzuca wyjątek ArgumentNullException.</exception>
        public int Front()
        {
            if (!IsEmpty()) return head.Next.Value;

            throw new ArgumentNullException("head.Next", "Wartość elementu, którą próbowano pobrać jest null.");
        }

        /// <summary>
        /// Sprawdza czy lista jest pusta.
        /// </summary>
        /// <returns>True gdy lista jest pusta, false jeśli nie.</returns>
        public bool IsEmpty()
        {
            return head.Next == tail ? true : false;
        }

    }

    public class Element
    {
        private int value;
        private Element previous, next;

        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
        public Element Previous
        {
            get
            {
                return this.previous;
            }
            set
            {
                this.previous = value;
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

    }
}
