using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class Node
  {
    public Node(int value)
    {
      Value = value;
    }

    public Node()
    {
      Value = 0;
    }
    
    public int Value { get; set; }

    public Node Next { get; set; }
  }
}
