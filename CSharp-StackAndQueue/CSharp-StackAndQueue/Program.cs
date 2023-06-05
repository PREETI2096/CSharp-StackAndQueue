namespace CSharp_StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stack and queue program");
            Node<int> node1 = new Node<int>(70);
            Node<int> node2 = new Node<int>(40);
            Node<int> node3 = new Node<int>(30);
            Node<int> node4 = new Node<int>(20);
            Node<int> node5 = new Node<int>(50);
            Queue queue = new Queue();
            queue.enqueue(node1);
            queue.enqueue(node2);   
            queue.enqueue(node3);
            queue.enqueue(node4);   
            queue.enqueue(node5);

            queue.dequeue();

        }
    }
}