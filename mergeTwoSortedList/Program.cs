namespace MergeTwoLists
{
    class Program
    {
        public static void Main(String[] args)
        {
            /* Sample node list1*/ 
            var listE = new ListNode(70, null);
            var listD = new ListNode(60, listE);
            var listC = new ListNode(48, listD);
            var listB = new ListNode(23, listC);
            var list1 = new ListNode(10, listB);

            /* Sample node list2*/ 

            var listG = new ListNode(40, null);
            var listF = new ListNode(30, listG);
            var list2 = new ListNode(14, listF);

            Solution sol = new Solution();
            ListNode current = sol.MergeTwoLists(list1, list2);

            var list = new List<int>();

            while (current != null)
            {              
                list.Add(current.val);
                current = current.next;
            }

            Console.WriteLine("------------------");
            Console.WriteLine($"Result is = [{string.Join(", ", list)}]");          
            Console.WriteLine("------------------");
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val, ListNode next)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
           
            ListNode result = new ListNode(0, null);
            ListNode current = result;
                  
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            if (list1 != null)
            {
                current.next = list1;
            }
            else
            {
                current.next = list2;
            }
            return result.next;
        }
    }
}