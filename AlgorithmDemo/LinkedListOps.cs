using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class LinkedListOps
    {
        public static void CountLinkedList()
        {
            Node head = new Node();
            Node second = new Node();
            Node third = new Node();

            head.Data = 1;
            head.Next = second;

            second.Data = 2;
            second.Next = third;

            third.Data = 3;
            third.Next = null;

            // Find total cound of linked list

            Node current = head;
            int count = 0;
            while (current != null)
            {
                Console.WriteLine(current.Data); 
                current = current.Next;                
                count++;
            }
            Console.WriteLine("Total count in the linked list: {0}", count);

            Console.WriteLine("Find the middle of the linked list: ");

            int mid = count / 2;

        }

        public static void InsertInLinkedList(Node head, int data, int position)
        {
            int k = 1;
            Node p, q, newNode;

            newNode = new Node();
            newNode.Data = data;
            p = head;

            // Inserting at the beginning
            if (position==1)
            {
                newNode.Next = p;
                head = newNode;
            }
            // Inserting at position
            while (head.Next != null)
            {
                Console.WriteLine(head.Data);
                head = head.Next;
            }
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }
}
