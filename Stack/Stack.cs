using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack<T> :IEnumerable<T>
    {
        // Вершина стеку (вузол, що доданий останнім).
        private Node<T> first;
        private int count;

        public bool IsEmpty { get => first == null; }
        public int Count { get => count; }

        // Додавання елементу у вершину стеку.
        public void Push(T component)
        {
            // Збереження посилання на вузол на вершині.
            Node<T> oldfirst = first;
            // Створення нового вузла.
            first = new Node<T>();
            first.item = component;
            // Прив'язка старої вершини до нової.
            first.next = oldfirst;
            count++;
        }

        // Видалення елементу із вершини стеку.
        public T Pop()
        {
            if (IsEmpty)
            { throw new InvalidOperationException("Стек порожній"); }
            // Вибірка значення елементу із вузла на вершині.
            T item = first.item;
            // Встановлення посилання на нову вершину.
            first = first.next;
            count--;
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = first;
            while (current != null)
            {
                yield return current.item;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
