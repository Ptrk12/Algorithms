//using System.Xml.Linq;

//Given the root of a binary tree, return the zigzag level order traversal of its nodes' values. (i.e., from left to right, then right to left for the next level and alternate between).



//Example 1:

//Input: root = [3,9,20,null,null,15,7]
//Output: [[3],[20,9],[15,7]]

//Example 2:

//Input: root = [1]
//Output: [[1]]

//Example 3:

//Input: root = []
//Output: []



//Constraints:

//    The number of nodes in the tree is in the range [0, 2000].
//    -100 <= Node.val <= 100

//Given the root of a binary tree, return the zigzag level order traversal of its nodes' values. (i.e., from left to right, then right to left for the next level and alternate between).



//Example 1:

//Input: root = [3,9,20,null,null,15,7]
//Output: [[3],[20,9],[15,7]]

//Example 2:

//Input: root = [1]
//Output: [[1]]

//Example 3:

//Input: root = []
//Output: []



//Constraints:

//    The number of nodes in the tree is in the range [0, 2000].
//    -100 <= Node.val <= 100




namespace Algorithms.Trees_and_graphs
{
    internal class Binary_Tree_Zigzag_Level_Order_Traversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            bool reverse = false;

            if (root == null)
                return result;
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var levelSize = queue.Count;
                var temp = new List<int>();

                for (int i = 0; i < levelSize; i++)
                {
                    var current = queue.Dequeue();

                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }
                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }

                    temp.Add(current.val);
                }
                result.Add(temp);
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (i % 2 != 0)
                {
                    if (result[i] is List<int> list)
                    {
                        list.Reverse();
                    }
                }
            }

            return result;
        }
    }
}
