using ValidateBinarySearchTree;

List<int> Traverse(TreeNode root, ref List<int> list)
{
    if (root.left != null)
    {
       Traverse(root.left, ref list);
    }
    
    list.Add(root.val);

    if (root.right != null)
    {
        Traverse(root.right, ref list);
    }
    
    return list;
}

bool IsValidBST(TreeNode root) {
    var list = new List<int>();
    list = Traverse(root, ref list);
    
    for (var x = 0; x < list.Count - 1; x++)
    {
        if (list[x] >= list[x + 1])
            return false;
    }

    return true;
}

/*var root = new TreeNode(5,
    new TreeNode(4),
    new TreeNode(6,
        new TreeNode(3),
        new TreeNode(7))
);*/


var root = new TreeNode(1,
    new TreeNode(1)
);

var result = IsValidBST(root);

Console.WriteLine(result);