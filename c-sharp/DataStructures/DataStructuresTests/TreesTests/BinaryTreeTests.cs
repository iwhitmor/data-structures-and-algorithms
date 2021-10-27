using System;
using System.Collections.Generic;
using DataStructures.Trees;
using Xunit;
namespace DataStructuresTests.TreesTests
{
  public class BinaryTreeTests
  {
    [Fact]
    public void Tree_is_empty()
    {
      //Arrange
      BinaryTree<int> t = new BinaryTree<int>();
     
      //Act
      bool result = t.IsEmpty;

      //Assert
      Assert.True(result);
    }

    [Fact]
    public void Can_instantiate_tree_with_single_root_node()
    {
      //Arrange
      BinaryTree<int> t = new BinaryTree<int>();
      t.Root = new Node<int>(1);

      //Act
      IEnumerable<int> result = t.PreOrder();


      //Assert
      Assert.Equal(new[] { 1 }, result);
    }

    [Fact]
    public void Can_add_left_child_and_right_child_to_root_node()
    {
      //Arrange
      BinaryTree<int> t = new BinaryTree<int>();
      t.Root = new Node<int>(1);
      t.Root.Left = new Node<int>(2);
      t.Root.Right = new Node<int>(3);

      //Act
      IEnumerable<int> result = t.PreOrder();

      //Assert
      Assert.Equal(new[] { 1, 2, 3 }, result);
    }
  }
}
