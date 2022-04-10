using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    // Клас для визначення вузлів.
    internal class Node<T>
    {
        public T item;
        public Node<T> next;
    }
}
