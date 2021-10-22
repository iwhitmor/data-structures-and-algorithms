using System;
using System.Collections.Generic;

namespace DataStructures.Trees
{
  public class BinaryTree<T>
  {
    public Node<T> Root { get; set; }

    public bool IsEmpty => Root == null;

    public IEnumerable<T> PreOrder()

    {
      return PreOrder(Root);
    }

    private IEnumerable<T> PreOrder(Node<T> root)
    {

      yield return root.Value;

      if (root.Left != null)
      {
        var leftValues = PreOrder(root.Left);
        foreach (T leftValue in leftValues)
        {
          yield return leftValue;
        }
      }

      if (root.Right != null)
      {
        foreach (T rightValue in PreOrder(root.Right))
        {
          yield return rightValue;
        }
      }
    }

    public IEnumerable<T> InOrder()
    {
      return InOrder(Root);
    }

    private IEnumerable<T> InOrder(Node<T> root)
    {
      if (root.Left != null)
      {
        InOrder(root.Left);
      }

      yield return root.Value;

      if (root.Right != null)
      {
        InOrder(root.Right);
      }
    }

    public IEnumerable<T> PostOrder()
    {
      return PostOrder(Root);
    }

    private IEnumerable<T> PostOrder(Node<T> root)
    {
      if (root.Left != null)
      {
        PostOrder(root.Left);
      }

      if (root.Right != null)
      {
        PostOrder(root.Right);
      }

      yield return root.Value;
    }
  }
}
