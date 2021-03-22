using System;
using System.Collections.Generic;

public class Node
{
    public int value;
    public Node next;

    public Node(int _value)
    {
        value = _value;
    }
}

public class LinkedList
{
    public Node head;
    public Node tail;

    public LinkedList()
    {
        head = null;
        tail = null;
    }

    public void AddInTail(Node _item)
    {
        if (head == null) head = _item;
        else tail.next = _item;
        tail = _item;
    }

    public Node Find(int _value)
    {
        Node node = head;
        while (node != null)
        {
            if (node.value == _value) return node;
            node = node.next;
        }

        return null;
    }

    public List<Node> FindAll(int _value)
    {
        List<Node> nodes = new List<Node>();
        Node node = head;
        while (node != null)
        {
            if (node.value == _value)
            {
                nodes.Add(node);
            }

            node = node.next;
        }

        return nodes;
    }

    public bool Remove(int _value)
    {
        Node node = head;
        Node previousNode = null;

        while (node != null)
        {
            if (node.value == _value)
            {
                if (node.next != null)
                {
                    if (previousNode == null)
                    {
                        head = node.next;
                    }
                    else
                    {
                        previousNode.next = node.next;
                    }
                }
                else
                {
                    if (previousNode == null)
                    {
                        head = null;
                        tail = null;
                    }
                    else
                    {
                        tail = previousNode;
                        previousNode.next = null;
                    }
                }

                return true;
            }

            previousNode = node;
            node = node.next;
        }

        return false;
    }

    public void RemoveAll(int _value)
    {
        while (!Remove(_value));
    }

    public void Clear()
    {
        head = null;
        tail = null;
    }

    public int Count()
    {
        if (head == null)
        {
            return 0;
        }
        
        int counter = 1;
        Node node = head;
        while (node.next != null)
        {
            counter += 1;
            node = node.next;
        }

        return counter;
    }

    public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
    {
        if (_nodeAfter == null)
        {
            if (_nodeToInsert != null)
            {
                Node currentHead = head;
                head = _nodeToInsert;
                _nodeToInsert.next = currentHead;
            }
        }

        while (_nodeAfter.next != null)
        {
            
        }
        
        // здесь будет ваш код вставки узла после заданного

        // если _nodeAfter = null , 
        // добавьте новый элемент первым в списке 
    }
}