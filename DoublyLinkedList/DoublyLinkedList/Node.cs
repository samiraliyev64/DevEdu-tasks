namespace DoublyLinkedList
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; internal set; }
        public Node<T> Previous { get; internal set; }

        public Node(T data)
        {
            this.Data = data;
        }
    }
}
