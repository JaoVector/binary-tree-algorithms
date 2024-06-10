public class Node
{
    public int Key;
    public Node? left, right;

    public Node(int key)
    {
        this.Key = key;
        left = right = null;
    }
}

