using System;
using System.Collections.Generic;

namespace DataStructures.LinkedListImpl
{
    public class SingleLinkedList<T> : ISingleLinkedList<T>
    {
        public int Count { get; set; }
        private Node<T> dataNode { get; set; }

        private Func<T, Node<T>, Node<T>> getNode = (value, next) => new Node<T>() { Value = value, Next = next };

        public void Add(T value)
        {
            if (Count == 0)
            {
                dataNode = getNode(value, null);
                Count++;
            }
            else
            {
                if (dataNode.Next == null)
                    dataNode.Next = getNode(value, null);
                else
                {
                    Node<T> tail = dataNode.Next;
                    while (tail.Next != null)
                    {
                        Node<T> temp = tail.Next;
                        tail.Next = temp.Next;
                    }
                    tail.Next = getNode(value, null);
                }
            }
        }

        public void AddFirst(T value)
        {
            throw new System.NotImplementedException();
        }

        public void AddLast(T value)
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T value)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Node<T>> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public T Remove(T value)
        {
            throw new System.NotImplementedException();
        }

        public void DisplayAllValues()
        {
            if (Count == 0)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                if (dataNode.Next == null)
                    Console.WriteLine(dataNode.Value);
                else
                {
                    Console.WriteLine(dataNode.Value);
                    Node<T> iterate = dataNode.Next;
                    while (iterate.Next != null)
                    {
                        Node<T> temp = iterate.Next;
                        Console.WriteLine(temp.Value);
                        iterate.Next = temp.Next;
                    }
                    Console.WriteLine(iterate.Value);
                }
            }
        }
    }
}
