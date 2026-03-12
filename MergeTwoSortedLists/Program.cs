using MergeTwoSortedLists;

/*
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
 */

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    ListNode root = new ListNode(0);
    ListNode? current = root;

    while (list1 != null || list2 != null)
    {
        if (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = new ListNode(list1.val);
                list1 =  list1.next;
            }
            else
            {
                current.next = new ListNode(list2.val);
                list2 = list2.next;
            }
        }
        else if (list1 != null)
        {
            current.next = new ListNode(list1.val);
            list1 = list1.next;
        }
        else if (list2 != null)
        {
            current.next = new ListNode(list2.val);
            list2 = list2.next;
        }
        
        current = current.next;
    }

    return root.next;
}

void PrintListNode(ListNode? listNode)
{
    while (listNode is not null)
    {
        Console.WriteLine(listNode.val + " -> ");
        listNode = listNode.next;
    }
}

var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

var result = MergeTwoLists(list1, list2);

PrintListNode(result);