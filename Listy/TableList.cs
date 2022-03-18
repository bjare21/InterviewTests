using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy
{
    public class TableList
    {
        private int n, table_size;
        private int[] table;

        public TableList()
        {
            n = 0;
            table_size = 100;
            table = new int[table_size];
        }

        public void Erase(int position)
        {
            for(int i = position; i < n-1; i++)
            {
                table[i] = table[i + 1];
            }
            n--;
        }

        /// <summary>
        /// Zwraca wartość pod wskazaną pozycją na liście.
        /// </summary>
        /// <param name="position">Pozycja szukanego elementu.</param>
        /// <returns>Wartość znajdująca się na szukanej pozycji.</returns>
        public int ValueAt(int position)
        {
            if (position < n) return table[position];
            throw new ArgumentOutOfRangeException("position", "Position musi być mniejsze od ilości elementów listy.");
        }

        /// <summary>
        /// Zwraca następną pozycję na liście względem przekazanej jako argument.
        /// </summary>
        /// <param name="position">Pozycja na liście, względem której szukamy następnej.</param>
        /// <returns>Następna pozycja na liście względem przesłanej.</returns>
        public int Next(int position)
        {
            if (position<n) return position + 1;
            throw new ArgumentOutOfRangeException("position", "Argument position musi być mniejszy od ilości elementów na liście");
        }

        /// <summary>
        /// Zwraca pozycję pierwszego elementu listy.
        /// </summary>
        /// <returns>Pozycja pierwszego elementu listy.</returns>
        public int First()
        {
            return 0;
        }

        /// <summary>
        /// Zwraca pozycję ostatniego elementu listy.
        /// </summary>
        /// <returns>Pozycja ostatniego elementu listy.</returns>
        public int Last()
        {
            return n - 1;
        }

        /// <summary>
        /// Wstawia wskazaną wartość we wskazanej pozycji listy.
        /// </summary>
        /// <param name="position">Pozycja na której wstawić nową wartość.</param>
        /// <param name="value">Nowa wartość.</param>
        public void Insert(int position, int value)
        {
            for(int i = n; i > position; i--)
            {
                table[i] = table[i - 1];
            }
            table[position] = value;
            n++;
        }

        /// <summary>
        /// Usuwa pierwszy element listy.
        /// </summary>
        public void PopFront()
        {
            Erase(0);
        }

        /// <summary>
        /// Usuwa ostatni element listy.
        /// </summary>
        public void PopBack()
        {
            n--;
        }

        /// <summary>
        /// Wstawia nową wartość na początku listy.
        /// </summary>
        /// <param name="value">Wartość wstawiana na początku listy.</param>
        public void PushFront(int value)
        {
            Insert(0, value);
        }

        /// <summary>
        /// Wstawia nową wartość na koniec listy.
        /// </summary>
        /// <param name="value">Wartość do wstawienia na końcu listy.</param>
        public void PushBack(int value)
        {
            Insert(n, value);
        }

        /// <summary>
        /// Zwraca pierwszą wartość listy.
        /// </summary>
        /// <returns>Pierwsza wartość listy</returns>
        public int Front()
        {
            return this.table[0];
        }

        /// <summary>
        /// Zwraca ostatnią wartość listy.
        /// </summary>
        /// <returns>Ostatnia wartość listy.</returns>
        public int Back()
        {
            return this.table[n - 1];
        }
        /// <summary>
        /// Sprawdza czy lista jest pusta.
        /// </summary>
        /// <returns>True jeżeli lista jest pusta, false jeżeli nie.</returns>
        public bool IsEmpty()
        {
            return n == 0 ? true : false;
        }
    }
}
