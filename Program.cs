using Algorithms.Trees_and_graphs;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            TreeNode t1 = new TreeNode(2);
            TreeNode t2 = new TreeNode(3);
            TreeNode t3 = new TreeNode(4);
            TreeNode t4 = new TreeNode(5);

            root.left = t1;
            root.right = t2;
            t1.left = t3;
            t1.right = t4;

            Binary_Tree_Zigzag_Level_Order_Traversal zigzag = new Binary_Tree_Zigzag_Level_Order_Traversal();
            var res = zigzag.ZigzagLevelOrder(root);

            Console.WriteLine();

        }
    }
}
