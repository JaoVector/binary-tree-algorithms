
public class BinarySearchTree : Node
{
    public static Node? MinValue(Node? node)
    {
        Node? currNode = node;

        while (currNode != null && currNode.left != null)
        {
            currNode = currNode.left;
        }

        return currNode;
    }

    public static Node? Insert(Node? node, int key)
    {
        if (node == null)
        {
            return CreateNode(key);
        }

        if(key < node.key)
        {
            node.left = Insert(node.left, key);
        } else if(key > node.key)
        {
            node.right = Insert(node.right, key);
        }

        return node;
    }

    public static Node? Delete(Node? root, int key)
    {
        if(root == null)
        {
            return root;
        }

        if (key < root.key)
        {
            root.left = Delete(root.left, key);
        } else if (key > root.key)
        {
            root.right = Delete(root.right, key);
        } else 
        {
            if(root.left == null)
            {
                Node? node = root.right;
                return node;
            } else if(root.right == null)
            {
                Node? node = root.left;
                return node;
            }

            Node? minNode = MinValue(root.right);

            root.key = minNode.key;

            root.right = Delete(root.right, minNode.key);
        }

        return root;
    }

    public static Node? Search(Node? root, int key)
    {
        if(root == null || root.key == key)
        {
            return root;
        }

        if(root.key < key)
        {
            return Search(root.right, key);
        } else 
        {
            return Search(root.left, key);
        }
    }

    public static void InorderTraversal(Node? node)
    {
        if(node == null)
        {
            return;
        }

        InorderTraversal(node.left);
        Console.WriteLine(node.key + " ");
        InorderTraversal(node.right);
    }
}
