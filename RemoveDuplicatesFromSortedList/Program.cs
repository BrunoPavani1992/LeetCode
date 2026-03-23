using RemoveDuplicatesFromSortedList;

ListNode DeleteDuplicates(ListNode head)
{
    if (head is null)
        return head;
    
    var resultHead = new ListNode(head.val);
    var result = resultHead;
    
    while (head.next != null) 
    {
        if (result.val != head.next.val)
        {
            result.next = new ListNode(head.next.val);
            result = result.next;
        }

        head = head.next;
    }

    return resultHead;
}

var list = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));

var result = DeleteDuplicates(list);

while (result != null)
{
    Console.Write(result.val + " -> ");
    result = result.next;
}
Console.Write("null");
