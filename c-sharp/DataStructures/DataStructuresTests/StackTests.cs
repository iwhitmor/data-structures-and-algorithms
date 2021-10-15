using System;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
  public class StackTests
  {

    [Fact]
    public void Can_instantiate_an_empty_stack()
    {
      //Arrange
      Stack stack = new Stack();

      //Act
      bool result = stack.IsEmpty;

      //Assert
      Assert.True(result);
    }

    [Fact]
    public void Can_push_onto_stack()
    {
      //Arrange
      Stack stack = new Stack();

      //Act
      stack.Push(1);
      

      //Assert
      Assert.False(stack.IsEmpty);
    }

    [Fact]
    public void Can_push_multiple_onto_stack()
    {
      //Arrange
      Stack stack = new Stack();
      stack.Push(1);

      //Act
      stack.Push(2);

      //Assert
      Assert.False(stack.IsEmpty);
    }

    [Fact]
    public void Can_peek_next_item_on_stack()
    {
      //Arrange
      Stack stack = new Stack();
      stack.Push(1);

      //Act
      int result = stack.Peek();

      //Assert
      Assert.Equal(1, result);

    }
  }
}