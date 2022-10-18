using System;

namespace DoublyLinkedList
{
    internal partial class Program
    {
        static int Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            Node<int> a = new Node<int>(1);
            Node<int> b = new Node<int>(2);
            Node<int> c = new Node<int>(3);
            linkedList.AddNodeToBeginning(a);
            linkedList.AddNodeToBeginning(b);
            linkedList.AddNodeToEnd(c);
            linkedList.OutputList();
            Console.ReadKey();
            return 0;
        }
    }
}