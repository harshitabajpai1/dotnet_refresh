using System;
using System.Collections.Generic;

static class TreeFlattenerHelper
{
    // Accept several root nodes in one call.
    public static List<string> FlattenTree(params TreeNode[] roots)
    {
        List<string> result = new List<string>();

        // Traverse each node with a scoped helper.
        void Traverse(TreeNode node, ref int currentDepth)
        {
            Console.WriteLine(node.Value + ": depth " + currentDepth);
            result.Add(node.Value);

            foreach (var child in node.Children)
            {
                int nextDepth = currentDepth + 1;
                Traverse(child, ref nextDepth);
            }
        }

        foreach (var root in roots)
        {
            int startDepth = 0;
            Traverse(root, ref startDepth);
        }

        return result;
    }
}

