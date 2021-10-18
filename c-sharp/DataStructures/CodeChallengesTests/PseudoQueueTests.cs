using System;
using Xunit;
using DataStructures;

namespace CodeChallengesTests
{
  public class PseudoQueueTests
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
      queue.Enqueue(2);

      //Act
      queue.Enqueue(3);

      //Assert
      Assert.False(queue.IsEmpty);
    }

    [Fact]
    public void Can_dequeue_out_of_queue_the_expected_value()
    {
      //Arrange
      Queue queue = new Queue();
      queue.Enqueue(1);
      queue.Enqueue(2);

      //Act
      int result = queue.Dequeue();

      //Assert
      Assert.Equal(1, result);
    }
  }
}
