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
      //TODO:fishing me
      //current = Head;

      //while (current ! = null)
      //{
      //  if current.value = value
      //  {
      //    return true;
      //  }

      return false;
    }

    //For now use override because Keith said so
    public override string ToString()
    {
      //TODO: Traverse to build the string
      return "NULL";
    }
  }
}
