using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack
{
    Node head;
    Node top;
    public Stack()
    {
        head = new Node();
        top = head;
    }

    public void Push(int data)
    {
        Node nextNode = new Node(data);
        top.next = nextNode;
        top = nextNode;
    }

    public int Pop()
    {
        Node node = head;
        if (IsEmpty())
        {
            Debug.Log("Õ»Îª¿Õ");
            return -1;
        }
        {
            while (node.next!= top)
            {
                node = node.next;
            }
            top = node;
            return node.next.data;
        }
    }
    public int Top()
    {
        if (IsEmpty())
        {
            Debug.Log("Õ»Îª¿Õ");
            return -1;
        }
        else
        {
            return top.data;
        }
    }
    
    public bool IsEmpty()
    {
        return head == top;
    }

}

public class Node
{
    public Node next = null;
    public int data;
    public Node(int data = 0)
    {
        this.data = data;
    }
}
