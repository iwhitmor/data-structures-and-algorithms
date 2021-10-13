using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public void Insert(int value)
    {
      Node newNode = new Node();
      newNode.Value = value;
      newNode.Next = Head;
      Head = newNode;
    }

    public bool Includes(int valueToFind)
    {
      //TODO:fishing me, needs a traversal

      Node current = Head;

      while (current != null)

      {
        //Do something interesting with current
        if (current.Value == valueToFind)

        {
          return true;
        }

        current = current.Next;
      }

      return false;
    }

    //For now use override because Keith said so
    public override string ToString()
    {
      //TODO: Traverse to build the string

      string output = "";

      Node current = Head;

      while (current != null)

      {
        output += current.Value;
        output += " -> ";

        current = current.Next;
      }

      return output + "NULL";
    }

    public void Append(int value)
    {
      //Create new node
      Node newNode = new Node();
      newNode.Value = value;
      Node current = Head;

      while (current != null)
      {
        if (current.Next == null)
        {
          current.Next = newNode;
          break;
        }
        else
        {
          current = current.Next;
        }
      }
    }

    public int KthFromEnd(int k)
    {
      int length = 0;

      Node current = Head;

      while (current != null)
      {
        current = current.Next;
        length++;
      }

      current = Head;

      for (int i = 0; i < length - k; i++)

        current = current.Next;
        return current.Value;
    }    
  }
}
