using System.Collections.Generic;

namespace DataStructures.LinkedListImpl
{
    public interface ISingleLinkedList<T>
    {
        public int Count { get; set; }

        void Add(T value);
        
        T Remove(T value);

        void AddFirst(T value);

        void AddLast(T value);

        bool Contains(T value);

        IEnumerable<Node<T>> GetEnumerator();

        void DisplayAllValues();
    }
}
