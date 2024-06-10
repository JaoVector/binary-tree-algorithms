
public class BinaryTree()
{
    public static void Postorder(Node node)
    {
        if (node == null)
            return;

        Postorder(node.left);

        Postorder(node.right);

        Console.WriteLine(node.data + " ");
    }
}