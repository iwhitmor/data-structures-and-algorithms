using System;
using Xunit;
using DataStructures.Trees;
using System.Collections.Generic;

namespace CodeChallengesTests
{
  public class TreeMaxTests
  {
    [Fact]
    public void FindMax_works_correctly()
    {
      //Arrange
      BinaryTree<int> t = new BinaryTree<int>();
      t.Root = new Node<int>(1);
      t.Root.Left = new Node<int>(2);
      t.Root.Right = new Node<int>(3);
      t.Root.Left.Left = new Node<int>(15);
      t.Root.Left.Right = new Node<int>(20);
      t.Root.Right.Left = new Node<int>(5);
      t.Root.Right.Right = new Node<int>(10);

      //Act
      int result = TreeMax.FindMax(t);

      //Assert
      Assert.Equal(20, result);
    }

    [Fact]
    public void FindMax_finds_max_with_one_node()
    {
      //Arrange
      BinaryTree<int> t = new BinaryTree<int>();
      t.Root = new Node<int>(100);

      //Act
      int result = TreeMax.FindMax(t);

      //Assert
      Assert.Equal(100, result);
    }
  }
}
