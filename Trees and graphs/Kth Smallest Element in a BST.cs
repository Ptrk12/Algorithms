//Given the root of a binary search tree, and an integer k, return the kth smallest value (1-indexed) of all the values of the nodes in the tree.

 

//Example 1:

//Input: root = [3, 1, 4, null, 2], k = 1
//Output: 1

//Example 2:

//Input: root = [5, 3, 6, 2, 4, null, null, 1], k = 3
//Output: 3




//Constraints:

//The number of nodes in the tree is n.
//    1 <= k <= n <= 104
//    0 <= Node.val <= 104

 

//Follow up: If the BST is modified often (i.e., we can do insert and delete operations) and you need to find the kth smallest frequently, how would you optimize?


namespace Algorithms.Trees_and_graphs
{
    internal class Kth_Smallest_Element_in_a_BST
    {
        private TreeNode _root;
        private int counter = 1;
        private int result = -1;
        public int KthSmallest(TreeNode root, int k)
        {
            InOrderTraversal(root, k);
            return result;
        }
        private void InOrderTraversal(TreeNode root, int k)
        {
            if(_root == null)
                _root = root;
            InOrderTraversalRec(root,k);
        }

        private void InOrderTraversalRec(TreeNode root, int k)
        {
            if(root != null && result == -1 )
            {
                InOrderTraversalRec(root.left,k);
                if (k == counter)
                {
                    result = root.val;
                }
                    
                counter++;
                InOrderTraversalRec(root.right,k);

            }
        }
    }
}
