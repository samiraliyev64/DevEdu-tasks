using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class CustomLinkedList
    {
        public int count;
        Node head;
        Node tail;
        public CustomLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void AddNodetoFront(int newData)
        {
            Node node = new Node(newData);
            node.next = head;
            head = node;
            count++;
        }

        public void AddNodetoBack(int newData)
        {
            Node node = new Node(newData);
            if(head == null)
            {
                head = node;
                return;
            }
            tail = head;
            while(tail.next != null)
            {
                tail = tail.next;
            }
            tail.next = node;
            count++;
        }
        public void Print()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
