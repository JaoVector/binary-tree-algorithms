
Node root = new(1)
{
    left = new Node(2),
    right = new Node(3),
};

root.left.left = new Node(4);
root.left.right = new Node(5);
root.right.right = new Node(6);

Console.WriteLine("PreOrder Traversal of Binary Tree");

BinaryTree.PreOrder(root);


/*

Visit the current node before visiting any nodes inside the left or right subtrees.
Here, the traversal is root – left child – right child. It means that the root node is traversed first then its left child and finally the right child.

*/