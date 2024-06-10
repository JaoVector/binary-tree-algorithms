

Node? root = null;

root = BinarySearchTree.Insert(root, 50);

BinarySearchTree.Insert(root, 30);
BinarySearchTree.Insert(root, 20);
BinarySearchTree.Insert(root, 40);
BinarySearchTree.Insert(root, 70);
BinarySearchTree.Insert(root, 60);
BinarySearchTree.Insert(root, 80);

BinarySearchTree.InorderTraversal(root);

BinarySearchTree.Delete(root, 70);

Console.WriteLine("===========================================================");

BinarySearchTree.InorderTraversal(root);

Console.WriteLine("===========================================================");


Node? resp = BinarySearchTree.Search(root, 20);
Console.WriteLine("Key found: " + resp.key);