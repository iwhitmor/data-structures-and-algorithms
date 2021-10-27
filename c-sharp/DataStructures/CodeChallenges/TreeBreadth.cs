using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Trees;
using DataStructures;

namespace CodeChallenges
{
  public class TreeBreadth
  {
    public static IEnumerable<int> BreadthFirst(BinaryTree<int> tree)
    {

      Queue breadth = new Queue();

      if (tree.Root == null)

        yield break;

      breadth.Enqueue(tree.Root);

      while (!breadth.IsEmpty)
      {
        Node front = breadth.Dequeue(); 
      }

      yield return front.value;

      if (Front.left != null)
      {
        breadth.Enqueue(int front.left);
      }

      if (Front.right != null)
      {
        breadth.Enqueue(Front.right);
      }
    }
  }
}

