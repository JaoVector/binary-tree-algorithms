public class BTree(int t)
{
    public Node? root = null; //ponteiro para o root da B-Tree
    public int t = t;

    public void Traverse()
    {
        if (root != null)
        {
            root.Traverse();
        }
    }

    public Node? Search(int key)
    {
        return root?.SearchKey(key);
    }

    public void InsertBTree(int key)
    {
        if (root == null)
        {
            root = new Node(t, true);
            root.Keys[0] = key;
            root.n = 1;
        }
        else
        {
            if (root.n == 2 * t - 1)
            {
                //If the root is full, create a new root and split the old root
                Node? newRoot = new Node(t, false);
                newRoot.Nodes[0] = root;
                newRoot.SplitChild(0, root);
                int i = 0;

                if (newRoot.Keys[0] < key)
                {
                    i++;
                }

                newRoot.Nodes[i].InsertNonFullNode(key);
                root = newRoot;
            }
            else
            {
                //if root is not full, insert into the root
                root.InsertNonFullNode(key);
            }
        }
    }

}
