
public class Node(int t, bool leaf)
{
    public int t = t; //quantidade minima de keys em um node
    public int n = 0; //quantidade de keys dentro do node atual
    public int[]? Keys = new int[2 * t - 1]; //keys de cada node
    public Node[]? Nodes = new Node[2 * t]; //Nodes da B-Tree que são as childs
    public bool leaf = leaf; //verdadeiro quando leaf é um node e falso caso não for


    public void InsertNonFullNode(int key)
    {
        int i = n - 1;

        if (leaf)
        {
            while (i >= 0 && Keys[i] > key)
            {
                Keys[i + 1] = Keys[i];
                i--;
            }

            Keys[i + 1] = key;
            n++;

        }
        else
        {
            //Insert key into a non-leaf node
            while (i >= 0 && Keys[i] > key)
            {
                i--;
            }

            if (Nodes[i + 1].n == 2 * t - 1)
            {
                //Split the child if its full
                SplitChild(i + 1, Nodes[i + 1]);

                if (Keys[i + 1] < key)
                {
                    i++;
                }
            }

            Nodes[i + 1].InsertNonFullNode(key);
        }
    }

    public void SplitChild(int i, Node y)
    {
        Node? z = new(y.t, y.leaf);
        z.n = t - 1;

        // Copy the second half of keys from y to z
        for (int j = 0; j < t - 1; j++)
        {
            z.Keys[j] = y.Keys[j + t];
        }

        // Copy the second half of child pointers from y to z if y is not a leaf
        if (!y.leaf)
        {
            for (int j = 0; j < t; j++)
            {
                z.Nodes[j] = y.Nodes[j + t];
            }
        }

        y.n = t - 1;

        // Rearrange keys and child pointers in the parent node
        for (int j = n; j > i; j--)
        {
            Nodes[j + 1] = Nodes[j];
        }

        Nodes[i + 1] = z;

        for (int j = n - 1; j >= i; j--)
        {
            Keys[j + 1] = Keys[j];
        }

        Keys[i] = y.Keys[t - 1];
        n++;
    }

    public void Traverse()
    {
        int i = 0;
        for (i = 0; i < n; i++)
        {
            if (leaf == false)
            {
                Nodes[i].Traverse();
            }
            Console.Write(Keys[i] + " ");
        }

        if (leaf == false)
        {
            Nodes[i].Traverse();
        }
    }

    public Node? SearchKey(int key)
    {
        int i = 0;
        while (i < n && key > Keys[i])
        {
            i++;
        }

        if (i < n && Keys[i] == key)
        {
            return this;
        }

        return leaf ? null : Nodes[i].SearchKey(key);
    }
}

