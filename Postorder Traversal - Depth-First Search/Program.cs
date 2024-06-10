
Node root = new Node(1)
{
    left = new Node(2),
    right = new Node(3)
};

root.left.left = new Node(4);
root.left.right = new Node(5);
root.right.right = new Node(6);

Console.WriteLine("Postorder Traversal Binary Tree");

BinaryTree.Postorder(root);
