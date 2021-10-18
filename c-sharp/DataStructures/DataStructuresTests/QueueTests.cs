using System;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
  public class QueueTests
  {

    [Fact]
    public void Can_instantiate_an_empty_queue()
    {
      //Arrange
      Queue queue = new Queue();

      //Act
      bool result = queue.IsEmpty;

      //Assert
      Assert.True(result);

    }

    [Fact]
    public void Can_enqueue_into_queue()
    {
      //Arrange
      Queue queue = new Queue();

      //Act
      queue.Enqueue(1);

      //Assert
      Assert.False(queue.IsEmpty);
    }

    [Fact]
    public void Can_enqueue_multiple_values_into_queue()
    {
      //Arrange
      Queue queue = new Queue();
      queue.Enqueue(1);

      //Act
      queue.Enqueue(2);

      //Assert
      Assert.False(queue.IsEmpty);
    }

    [Fact]
    public void Can_peek_at_next_queue_line()
    {
      //Arrange
      Queue queue = new Queue();
      queue.Enqueue(1);

      //Act
      int result = queue.Peek();

      //Assert
      Assert.Equal(1, result);
    }

    [Fact]
    public void Peek_should_throw_when_empty()
    {
      //Arrange
      Queue queue = new Queue();


      //Assert
      Assert.Throws<InvalidOperationException>(() =>
      {
        //Act
        queue.Peek();

      });
    }

    [Fact]
    public void Can_dequeue_out_of_queue_the_expected_value()
    {
      //Arrange
      Queue queue = new Queue();
      queue.Enqueue(1);

      //Act
      int result = queue.Dequeue();

      //Assert
      Assert.Equal(1, result);
      Assert.True(queue.IsEmpty);
    }
  }
}
