public class RedBlackTree
{
    public Node? root;

    public RedBlackTree()
    {
        root = null;
    }

    public class Node
    {
        public int data;
        public Node? left, right;
        public char color;
        public Node? parent;

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
            color = 'R';
            parent = null;
        }
    }

    public Node RotateLeft(Node? node)
    {
        Node? x = node.right;
        Node? y = node.left;

        x.left = node;
        node.right = y;
        node.parent = x;

        if (y != null)
        {
            y.parent = node;
        }

        return x;
    }

    public Node RotateRight(Node? node)
    {
        Node? x = node.left;
        Node? y = node.right;
        
        x.right = node;
        node.left = y;
        node.parent = x;

        if (y != null)
        {
            y.parent = node;
        }

        return x;
    }

    bool ll = false;
    bool rr = false;
    bool lr = false;
    bool rl = false;

    public Node InsertionValidation(Node? root, int data)
    {
        bool f = false;

        if (root == null)
        {
            return new Node(data);
        }
        else if (data < root.data)
        {
            root.left = InsertionValidation(root.left, data);
            root.left.parent = root;

            if (root != this.root)
            {
                if (root.color == 'R' && root.left.color == 'R')
                {
                    f = true;
                }
            }
        }
        else
        {
            root.right = InsertionValidation(root.right, data);
            root.right.parent = root;

            if (root != this.root)
            {
                if (root.color == 'R' && root.right.color == 'R')
                {
                    f = true;
                }
            }
        }


        switch (true)
        {
            case bool x when x == ll:
                root = RotateLeft(root);
                root.color = 'B';
                root.left.color = 'R';
                ll = false;
                break;

            case bool x when x == rr:
                root = RotateRight(root);
                root.color = 'B';
                root.right.color = 'R';
                rr = false;
                break;

            case bool x when x == rl:
                root.right = RotateRight(root.right);
                root.right.parent = root;
                root = RotateLeft(root);
                root.color = 'B';
                root.left.color = 'R';
                rl = false;
                break;

            case bool x when x == lr:
                root.left = RotateLeft(root.left);
                root.left.parent = root;
                root = RotateRight(root);
                root.color = 'B';
                root.right.color = 'R';
                lr = false;
                break;
            default:
                break;
        }

        if (f)
        {
            if (root.parent.right == root)
            {
                if (root.parent.left == null || root.parent.left.color == 'B')
                {
                    if (root.left != null && root.left.color == 'R')
                    {
                        rl = true;
                    }
                    else if (root.right != null && root.right.color == 'R')
                    {
                        ll = true;
                    }
                }
                else
                {
                    root.parent.left.color = 'B';
                    root.color = 'B';
                    if (root.parent != this.root)
                    {
                        root.parent.color = 'R';
                    }
                }
            }
            else
            {
                if (root.parent.right == null || root.parent.right.color == 'B')
                {
                    if (root.left != null && root.left.color == 'R')
                    {
                        rr = true;
                    }
                    else if (root.right != null && root.right.color == 'R')
                    {
                        lr = true;
                    }
                }
                else
                {
                    root.parent.right.color = 'B';
                    root.color = 'B';
                    if (root.parent != this.root)
                    {
                        root.parent.color = 'R';
                    }
                }
            }

            f = false;
        }

        return root;
    }

    public void Insert(int data)
    {
        if (root == null)
        {
            root = new Node(data);
            root.color = 'B';
        }
        else
        {
            root = InsertionValidation(root, data);
        }
    }

    public void InorderTraversal(Node? node)
    {
        if (node != null)
        {
            InorderTraversal(node.left);
            Console.Write(node.data + " ");
            InorderTraversal(node.right);
        }
    }

    public void InorderTaversalCall()
    {
        InorderTraversal(root);
    }
}
