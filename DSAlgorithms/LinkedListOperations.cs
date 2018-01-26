using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithms
{
    public class LinkedListOperations
    {        
        public void CountLinkedList()
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
                current = current.Next;
                Console.WriteLine(current);
                count++;
            }
        }

        // Find the middle of linked list
        // Search from liked list
        // Check whether it contains or not
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }
}
