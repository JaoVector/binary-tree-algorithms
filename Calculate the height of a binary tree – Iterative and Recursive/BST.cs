using System;

public class BSTree
{
    public Node? root;

    public BSTree()
    {
        root = null;
    }

    public void Insere(int key)
    {
        root = InsereKey(root, key);
    }

    public static Node? InsereKey(Node? root, int key)
    {
        if (root == null)
        {
            root = new Node(key);
            return root;
        }

        if (key > root.Key)
        {
            root.right = InsereKey(root.right, key);
        }
        else if (key < root.Key)
        {
            root.left = InsereKey(root.left, key);
        }

        return root;
    }

    public int RetornaResult()
    {
        return CalculaAltura(root);
    }

    public static int CalculaAltura(Node? root)
    {
        if (root == null)
        {
            return -1;
        }
        else
        {
            int leftDepht = CalculaAltura(root.left);
            int rightDepht = CalculaAltura(root.right);

            return Math.Max(leftDepht, rightDepht) + 1;
        };
    }
}
