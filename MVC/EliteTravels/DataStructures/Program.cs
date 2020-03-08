using DataStructures.LinkedListImpl;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SingleLinkedList<int> linkedList = new SingleLinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);

            linkedList.DisplayAllValues();

            Console.ReadKey();
        }
    }
}
