namespace ReverseLinkedList
{
    class Program
    {
        public static void Main(String[] args)
        {
            /*Sample node list*/
            var listE = new ListNode(20, null);
            var listD = new ListNode(90, listE);
            var listC = new ListNode(85, listD);
            var listB = new ListNode(42, listC);
            var list1 = new ListNode(100, listB);

            var sol = new ListNode();          
            ListNode current = sol.ReverseList(list1);

            var list = new List<int>();
            while (current != null)
            {              
                list.Add(current.val);
                current = current.next;
            }

            Console.WriteLine("------------------");
            Console.WriteLine($"Reversed result is = [{string.Join(", ", list)}]");          
            Console.WriteLine("------------------");
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
            public ListNode ReverseList(ListNode head)
            {
                // Initialize the reversed list to null
                ListNode reversedList = null;

                // Iterate through the original list
                while (head != null)
                {
                    // Save a reference to the current node
                    ListNode currentNode = head;

                    // Move the head to the next node in the original list
                    head = head.next;

                    // Add the current node to the front of the reversed list
                    currentNode.next = reversedList;
                    reversedList = currentNode;
                }

                // Return the reversed list
                return reversedList;
            }
        }
    }
}