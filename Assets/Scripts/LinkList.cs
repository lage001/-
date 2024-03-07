using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeList
{
    Node head;
    public NodeList()
    {
        head = new Node();
    }

    public void Insert(int data)
    {
        Node nextNode = new Node(data);
        Top().next = nextNode;
    }

    public Node Top()
    {
        Node node = head;
        while(node.next != null)
        {
            node = node.next;
        }
        return node;
    }
    public int Pop()
    {
        Node node = Top();
        int data = node.data;
        node = null;
        return data;

    }
    public bool Empty()
    {
        return head.next == null;
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
