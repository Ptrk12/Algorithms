namespace Algorithms.Trees_and_graphs
{
    internal class Binary_Tree_Inorder_Traversal
    {
        TreeNode Root = null;
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            if (Root == null)
                Root = root;

            InorderTraversalRecursion(Root,result);

            return result;
        }

        private void InorderTraversalRecursion(TreeNode node, List<int> list)
        {
            if(node != null)
            {
                InorderTraversalRecursion(node.left,list);
                list.Add(node.val);
                InorderTraversalRecursion(node.right, list);
            }
        }

    }
}
