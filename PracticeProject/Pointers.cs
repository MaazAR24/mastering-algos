namespace PracticeProject
{
    internal class Pointers
    {
        unsafe static void Execute()
        {
            Node* pointer = null;

            var n1 = SetNode(10, null);
            var n2 = SetNode(15, &n1);
            var n3 = SetNode(5, &n2);

            pointer = &n3;

            Console.WriteLine(n2.next->data);
        }

        unsafe static Node SetNode(int val, Node* next)   // CS0227
        {
            Node n1 = new Node();
            n1.data = val;
            n1.next = next;

            return n1;
        }


        unsafe struct Node
        {
            public int data;
            public Node* next;
        }

    }
}
