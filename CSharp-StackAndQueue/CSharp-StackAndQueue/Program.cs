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
            Stack stack = new Stack();
            stack.push(node1);
            stack.push(node2);  
            stack.push(node3);
            stack.push(node4);
            stack.push(node5);
            stack.pop();
        }
    }
}