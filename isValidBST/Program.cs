namespace IsValidBST;

public class Program
{
    public static void Main(String[] args)
    {


    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, null, null);
        }
        private bool IsValidBST(TreeNode node, int? min, int? max)
        {
            if (node == null)
            {
                return true;
            }

            if (min != null && node.val <= min || max != null && node.val >= max)
            {
                return false;
            }

            return IsValidBST(node.left, min, node.val) && IsValidBST(node.right, node.val, max);
        }
    }
}
