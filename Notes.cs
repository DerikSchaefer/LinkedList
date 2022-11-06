namespace LinkedList
{
    internal class Notes
    {

        /*  

                Advantages:

        Linked Lists are dynamic data structures made up Nodes

        Unlike Arrays, data is not stored in contiguous memory locations

        Insertion and deletion of elements is easier. There is no need to reallocate
        or reogranize structure. With an array you need to shift elements, with a linked
        no physical movement of data. 

                Can be used to implement abstract data types like lists, stacks, queues.

        Disadvantages:

        Efficient random acecss is not possible

        Implementation requires extra memory


        Variants of LinkedLists:
        1. Single Linked Lists
        2. Double Linked Lists
        3. Circular Linked Lists
        4. Linked Lists with Head Node


        Single Linked List:

        Made up of nodes, each node has two parts: Info & Link

        The info is the data of the node, the link is a reference to the next node.

        The last node will have it's link part equal to null

        We will maintain a spatial reference variable that always refers to the first
        node of the list. This reference is the identity of the list and only with this
        can we access all the elements of the linkedlist.

        Like a node with no data only link part that points to first node

        When empty the spatial reference variable will be equal to null



        Creating a single linked list:

        We first defined the node object:

        info represents the data, this is type int but it can be other types
        Node will be the link. One argument constructor, info equal to i and link is
        equal to null.

        In our SingleLinkedList


        class Node
    {
        public int info;
        public Node link;
        public Node(int i)
        {
            info = i;
            link = null;
        }
    }


          class SingleLinkedList
        {

        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }


        Traversing a LinkedList

        We first need to learn how to move a reference forward. Suppose we have a reference "p"

        if we do this: p = p.link; 

        this will move the reference p forward in the LinkedList

        To do this traversal we will need to make p refer to the first node. To do this we will do this:

        Node p = start;

        We do this because start refers to the first node. 

        Then to traverse we can do:

        Node p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }

        If we wanted to count the nodes we could just change it to this:

          int n = 0;
          Node p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
        Console.WriteLine("Number of nodes=" + n);

        If we wanted to search for an element in the list, say element x. We will traverse the list and everytime
        we access a node we will check if the info of that node is equal to x and this position variable will give us the
        position of the node that contains x

        int position = 1;
        Node p = start;

        while (p != null) 
        {
        if (p.info == x) 
        {
        break;
        }
        position++;
        p = p.link;
        }

        if (p == null) 
        Console.WriteLine(x + " not found in list");
        else
        Console.WriteLine(x + " is at position " + position);


        if we want to find reference to the last node we would do
        while p.link != null
        p = p.link;

        second last node would be 
        while p.link.link != null
        etc

        If we wanted to find reference to the predecessor of a node with particular info we would do this:

        if (p.link.info == x)
        break;
        else 
        p = p.link;

        If we wanted to find reference to a node at a particular position we could do this

        p = start;

        for (int i = 1; i < k && p != null; i++) 
        p = p.link;


        Insertion in a Single Linked List

        1. Insertion at beggining
        2. Insertion in an empty list
        3. Insertion at the end
        4. Insertion in between the list nodes


      

        Think of a  non empty list. We have our first node which has info and a link and then we have our 'start' reference which
        only contains a link to the first node

          If we're trying to insert at the beginning of a not empty linked list we need to make use of a temp node. 

        We're going to make temp.link = start (this makes temp point to the first node, same as start)
        
        Then we will make start = temp;

        So all together

        temp.link = start;
        start = temp;

        This temp node will be the new first node in the linked list.

    }
}
