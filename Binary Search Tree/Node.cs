
public class Node 
{
    public int key;
    public Node? left, right;

    public static Node CreateNode(int key)
    {
        Node node = new()
        {
            key = key
        };
        node.left = node.right = null;
        return node;
    }
}