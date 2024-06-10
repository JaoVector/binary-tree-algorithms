
BSTree tree1 = new();
BSTree tree2 = new();

int[] array = [1, 2, 3, 4, 5, 6, 7];
int[] array2 = [1, 2, 3, 4, 5, 8, 7];

foreach (var i in array)
{
    tree1.InsereKey(i);
}

foreach (var j in array2)
{
    tree2.InsereKey(j);
}

tree1.InorderTraversal(tree1.root);
Console.WriteLine();
tree2.InorderTraversal(tree2.root);

Console.WriteLine();

int hTree1 = tree1.CalculaAlturaArvore(tree1.root);
int hTree2 = tree2.CalculaAlturaArvore(tree2.root);

var resp = tree1.VerificaIgualdade(tree1.root, tree2.root);

if (hTree1 != hTree2)
{
    Console.WriteLine("Both binary trees have different structures.");
}
else if(resp == false)
{
    Console.WriteLine("Both binary trees have the same structure but differ in nodes’ values.");
} else 
{
    Console.WriteLine("Both binary trees have the same structure and contents.");
}
