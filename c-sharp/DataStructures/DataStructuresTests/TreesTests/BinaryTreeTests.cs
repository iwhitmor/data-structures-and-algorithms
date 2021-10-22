using System;
using System.Collections.Generic;
using DataStructures.Trees;
using Xunit;
namespace DataStructuresTests.TreesTests
{
  public class BinaryTreeTests
  {
    [Fact]

    public void Binary_tree_is_empty()
    {
      //Arrange
      BinaryTree<int> t = new BinaryTree<int>();
      //t.Root = new Node<int>(1);

      //Act
      bool result = t.IsEmpty;

      //Assert
      Assert.True(result);
    }


  }
}
