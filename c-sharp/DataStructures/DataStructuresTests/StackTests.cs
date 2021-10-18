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

    [Fact]
    public void Can_pop_off_stack()
    {
      //Arrange
      Stack stack = new Stack();
      stack.Push(1);

      //Act
      int result = stack.Pop();

      //Assert
      Assert.Equal(1, result);
      Assert.True(stack.IsEmpty);
    }

    [Fact]
    public void Pop_works_for_stack_with_multiple_values()
    {
      //Arrange
      Stack stack = new Stack();
      stack.Push(1);
      stack.Push(2);

      //Act
      int result = stack.Pop();

      //Assert
      Assert.Equal(2, result);
      Assert.Equal(1, stack.Peek());
      Assert.False(stack.IsEmpty);
    }

    [Fact]
    public void Can_empty_stack_after_multiple_pops()
    {
      //Arrange
      Stack stack = new Stack();
      stack.Push(1);
      stack.Push(2);

      //Act
      stack.Pop();
      stack.Pop();

      //Assert
      Assert.True(stack.IsEmpty);
    }

    [Fact]
    public void Peek_should_throw_when_empty()
    {
      //Arrange
      Stack stack = new Stack();

      //Assert
      Assert.Throws<InvalidOperationException>(() =>
      {

        //Act
        stack.Peek();

      });



    }
  }
}