public class BSTree
{
    public Node? root;

    public void InsereKey(int key)
    {
        if (root == null)
        {
            root = new Node(key);
        }
        else
        {
            root.InsereKeyBST(root, key);
        }
    }

    public int CalculaAlturaArvore(Node? root)
    {
        if (root == null)
        {
            return 0;
        }

        return root.CalculaAltura(root);
    }

    public bool VerificaIgualdade(Node? root1, Node? root2)
    {
        if (root == null)
        {
            return false;
        }

        return root.VerificaIgualdadeTree(root1, root2);
    }

    public void InorderTraversal(Node? root)
    {
        if (root == null)
        {
            return;
        }

        root.InorderTraversal(root);
    }
}