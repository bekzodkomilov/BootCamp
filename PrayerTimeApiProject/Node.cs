namespace lesson10
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node(T data)
        {
            Data = data;
        }
    }
}