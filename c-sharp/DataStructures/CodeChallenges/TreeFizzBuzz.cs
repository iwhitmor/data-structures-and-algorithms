using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Trees;
using DataStructures;

namespace CodeChallenges
{
  public class TreeFizzBuzz
  {
   public static BinaryTree<string> FizzBuzz(BinaryTree<int> tree)
   {
      Node<string> FizzBuzz(Node<int> node)
      {
        if (node % 3 == 0)
        {
          return "Fizz";
        }
      }

      BinaryTree<string> r = new BinaryTree<string>();

      r.Root = FizzBuzz(tree.Root);

      return r;
    }
  }
}
