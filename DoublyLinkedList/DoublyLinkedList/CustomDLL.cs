using System;

namespace DoublyLinkedList
{
    public class LinkedList<T>
    {
        public Node<T> First { get; private set; }
        public Node<T> Last { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            this.First = null;
            this.Last = null;
        }

        public void AddNodeToBeginning(Node<T> newNode)
        {
            if (this.First == null)
            {
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                newNode.Next = this.First;
                First.Previous = newNode;
                this.First = newNode;
            }
            Count++;
        }

        public void AddNodeToEnd(Node<T> newNode)
        {
            if (this.Last == null)
            {
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                this.Last.Next = newNode;
                newNode.Previous = Last;
                Last = newNode;
            }
            Count++;
        }

        public void RemoveFirst()
        {
            if (First == null || this.Count == 0)
            {
                return;
            }
            First = First.Next;
            this.Count--;
        }

        public Node<T> GetLastNode()
        {
            Node<T> node = First;
            while (node != null)
            {
                node = node.Next;
            }
            return node;
        }
        
        public void OutputList()
        {
            Node<T> node = First;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }
    }
}