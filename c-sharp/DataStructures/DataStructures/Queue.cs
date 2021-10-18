using System;
namespace DataStructures
{
  public class Queue
  {
    private Node front;
    private Node rear;

    public bool IsEmpty => front == null;
    
    public void Enqueue(int value)
    {
      Node node = new Node(value);

      if (rear == null)

      {
        front = node;
        rear = node;
      }

      else

      {
        rear.Next = node;
      }
    }
  }
}
