using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public void Insert(int v)
    {
      Node newNode = new Node();
      newNode.Value = v; 

      Head = newNode;
    }
  }
}
