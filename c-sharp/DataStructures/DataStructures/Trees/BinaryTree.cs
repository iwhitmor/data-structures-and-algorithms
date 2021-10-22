using System;
using System.Collections.Generic;

namespace DataStructures.Trees
{
  public class BinaryTree<T>
  {
    public Node<T> Root { get; set; }

    public IEnumerable<T> PreOrder()

    {
      return PreOrder(Root);
    }

    private IEnumerable<T> PreOrder(Node<T> root)
    {

      yield return root.Value;

      if (root.Left != null)
      {
        PreOrder(root.Left);
      }

      if (root.Right != null)
      {
        PreOrder(root.Right);
      }
    }
  }

    //public IEnumerable<T> InOrder(Node<T> Root)
    //{
    //  if (Root.Left != null)
    //  {
    //    InOrder(Root.Left);
    //  }

    //  T output = Root.Value;

    //  if (Root.Right != null)
    //  {
    //    InOrder(Root.Right);
    //  }
    //  return output;

    //}
  }
}
