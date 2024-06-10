
public class Node
{
    public Node? left, right;
    public int key;

    public Node(int data)
    {
        key = data;
        left = right = null;
    }

    public Node? InsereKeyBST(Node? node, int key)
    {

        if (node == null)
        {
            return new Node(key);
        }

        if (key < node.key)
        {
            node.left = InsereKeyBST(node.left, key);
        }
        else if (key > node.key)
        {
            node.right = InsereKeyBST(node.right, key);
        }

        return node;
    }

    public int CalculaAltura(Node? root)
    {
        if (root == null)
        {
            return -1;
        }

        int leftDepht = CalculaAltura(root.left);
        int rightDepht = CalculaAltura(root.right);

        if (leftDepht > rightDepht)
        {
            return leftDepht + 1;
        }
        else
        {
            return rightDepht + 1;
        }
    }

    public bool VerificaIgualdadeTree(Node? tree1, Node? tree2)
    {
        if (tree1 == null || tree2 == null)
        {
            return true;
        }

        if (tree1 != null && tree2 != null)
        {
            return (tree1.key == tree2.key)
                && VerificaIgualdadeTree(tree1.left, tree2.left)
                && VerificaIgualdadeTree(tree1.right, tree2.right);
        }

        return false;
    }


    public void InorderTraversal(Node? node)
    {
        if (node == null)
        {
            return;
        }

        InorderTraversal(node.left);
        Console.Write(node.key + " ");
        InorderTraversal(node.right);
    }
}
