
BTree bTree = new BTree(3);

int[] array = [10, 20, 5, 6, 12, 30, 7, 17];

foreach (var item in array)
{
    bTree.InsertBTree(item);
}

Console.WriteLine("Traversal of the B-Tree");
bTree.Traverse();
Console.WriteLine();

int key = 6;

Console.WriteLine(bTree.Search(key) != null ? "Present" : "Not Present");


/*
B-Tree Properties

1 - For each node x, the keys are stored in increasing order.
2 - In each node, there is a boolean value x.leaf which is true if x is a leaf.
3 - If n is the order of the tree, each internal node can contain at most n - 1 keys along with a pointer to each child.
4 - Each node except root can have at most n children and at least n/2 children.
4 - All leaves have the same depth (i.e. height-h of the tree).
5 - The root has at least 2 children and contains a minimum of 1 key.
6 - If n ≥ 1, then for any n-key B-tree of height h and minimum degree t ≥ 2, h ≥ logt (n+1)/2.
*/