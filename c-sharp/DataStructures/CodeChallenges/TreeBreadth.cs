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

      breadth.Enqueue(tree.Root.Value);

      while (!breadth.IsEmpty)
      {
        node front = breadth.Dequeue(); 
      }

      yield return front.value;

      if (front.left != null)
      {
        breadth.Enqueue(front.left);
      }

      if (front.right != null)
      {
        breadth.Enqueue(front.right);
      }
    }
  }
}

