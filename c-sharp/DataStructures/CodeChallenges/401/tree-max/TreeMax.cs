using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Trees;

namespace DataStructures.Trees
{
  public class TreeMax
  { 
    public int FindMax(BinaryTree<int> tree)
    {
      return tree.PreOrder().Max();
    }   
  }
}
