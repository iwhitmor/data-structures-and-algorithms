using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Trees;
using DataStructures;


namespace CodeChallenges
{
  public class TreeBreadth
  {
    public static IEnumerable<T> BreadthFirst<T>(BinaryTree<T> tree)
    {

      Queue<Node<T>> q = new Queue<Node<T>>();

      if (tree.Root == null)

        yield break;

      q.Enqueue(tree.Root);

      while (q.Count > 0)
      {
        Node<T> next = q.Dequeue();
        yield return next.Value;

        if (next.Left != null)

          q.Enqueue(next.Left);

        if (next.Right != null)

          q.Enqueue(next.Right);
      }
    }
  }
}

