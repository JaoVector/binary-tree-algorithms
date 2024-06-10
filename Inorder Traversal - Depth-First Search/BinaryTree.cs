
public class BinaryTree
{
    public static void Inorder(Node node)
    {
        if (node == null)
            return;

        Inorder(node.left);

        Console.WriteLine(node.data + " ");

        Inorder(node.right);
    }
}