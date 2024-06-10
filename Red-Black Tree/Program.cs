

int[] array = [1, 4, 6, 3, 5, 7, 8, 2, 9];

RedBlackTree blackTree = new();

for (int i = 0; i < array.Length; i++)
{
    blackTree.Insert(array[i]);
}

blackTree.InorderTaversalCall();