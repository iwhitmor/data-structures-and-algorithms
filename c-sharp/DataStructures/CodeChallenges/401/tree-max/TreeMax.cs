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
      //Cant use this built in method
      //return tree.PreOrder().Max();

      int max = tree.Root.Value;

      foreach (var i in tree.PreOrder())
      {
        if (i > max) max = i;
      }
      return max;
    }   
  }
}
