
Node root = new(1)
{
    left = new Node(2),
    right = new Node(3),
};

root.left.left = new Node(4);
root.left.right = new Node(5);
root.right.right = new Node(6);


Console.WriteLine("Inorder Traversal of Binary Tree");

BinaryTree.Inorder(root);


/*
Visit the current node after visiting all nodes inside the left subtree but before visiting any node within the right subtree. Here, the traversal is left child – root – right child.
It means that the left child is traversed first then its root node and finally the right child.
*/