using Algorithms.Trees_and_graphs;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(5);
            TreeNode n1 = new TreeNode(3);
            TreeNode n2 = new TreeNode(6);
            TreeNode n3 = new TreeNode(2);
            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(1);

            root.left = n1;
            root.right = n2;
            n1.right = n4;
            n1.left = n3;
            n3.left = n5;

            Kth_Smallest_Element_in_a_BST test = new Kth_Smallest_Element_in_a_BST();

           var res = test.KthSmallest(root,3);
            Console.WriteLine(res);


        }
    }
}
