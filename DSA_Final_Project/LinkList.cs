using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA_Final_Project
{
    public class linklist
    {
        public Node head;
        public int size = 0;

        public void insert(item item1)
        {
            size++;
            linklist.Node temp = new linklist.Node(item1);
            if (head == null)
            {
                head = temp;
                return;
            }
            else
            {
                temp.next = head;
                head = temp;
            }
     }
        
        public void delete_end()
        {
            linklist.Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }
        public int search(int data)
        {
            Console.WriteLine("Searching " + data + " in the LinkList");
            int count = 0;
            linklist.Node temp = head;
            while (temp.next != null)
            {
                if (temp.data.Equals(data))
                {
                    Console.WriteLine("Data Found");
                    return count;
                }
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Data not found");
            return -1;
        }
        public bool empty()
        {
            Console.WriteLine("Is LinkList empty ");
            return size == 0;
        }
        public void transvers()
        {
            Console.WriteLine("Transversing");
            linklist.Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine("null");
        }
        public void merge(linklist l2)
        {
            linklist.Node temp = l2.head;
            while (temp != null)
            {
                insert(temp.data);
                temp = temp.next;
            }

        }
        //sorting linklist
        public item[] sortBy(bool Condition = true)
        {
            item[] arra = new item[size];
            arra = get_items();
            if (Condition)
            {
                Array.Sort(arra, delegate(item x, item y) { return y.price_item.CompareTo(x.price_item); });
            }
            else
                Array.Sort(arra, delegate(item x,item y){return y.size.CompareTo(x.size);});
            return arra;
        }
        //moving linklist in to array
        public item[] get_items()
        {
            item[] arra = new item[size];
            linklist.Node temp = head;
            int count = 0;
            while (temp != null)
            {
                arra[count++] = temp.data;
                temp = temp.next;
            }
            return arra;
        }
        public class Node
        {
            public item data;
            public Node next = null;

            public Node(item data)
            {
                this.data = data;
            }
        };
        
    }
    
}
