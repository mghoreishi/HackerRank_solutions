public static  Node insert(Node head,int data)
	{
      //Complete this method
      Node node = new Node(data);
        if (head == null) {
            head = node;
        }
        else {
            if (head.next == null) {
                head.next = node;
            }
            else {
                Node current = head;
                while (current.next != null) {
                    current = current.next;
                }
                current.next = node;
            }
        }
        return head;
    }
