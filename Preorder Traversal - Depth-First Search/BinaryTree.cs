public class BinaryTree
{
    public static void PreOrder(Node node)
    {
        if(node == null)
        {
            return;
        }

        Console.WriteLine(node.data + " ");
        PreOrder(node.left);
        PreOrder(node.right);
    }
}