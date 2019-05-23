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
            int count= 1;
            Node currentHead=null, tempNode=null, newNode;

            newNode = new Node();
            newNode.Data = data;
            currentHead = head;

            // Show the list 
            Console.WriteLine("Before LinkedList operations: ");
            while (head != null)
            {
                Console.Write(head.Data  + " ");
                head = head.Next;
            }
            Console.Write("\n");

            // Inserting at the beginning
            if (position == 1)
            {
                // 1. Update the next pointer of new node, to point to the current head                
                newNode.Next = currentHead;

                // 2. Update head pointer to point to the new noede. 
                head = newNode;
            }
            else
            {
                // Traverse the list until the position where we want to insert
                while (currentHead != null && count < position)
                {
                    count++;
                    tempNode = currentHead;
                    currentHead = currentHead.Next;
                }
                tempNode.Next = newNode;
                newNode.Next = currentHead;
            }

            // Show the list after the operation
            Console.WriteLine("After LinkedList operations: ");
            while (tempNode != null)
            {
                Console.Write(tempNode.Data + " ");
                tempNode = tempNode.Next;
            }
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }
}
