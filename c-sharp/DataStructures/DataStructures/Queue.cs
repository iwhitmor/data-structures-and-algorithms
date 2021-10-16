using System;
namespace DataStructures
{
  public class Queue
  {
    private Node front;
    private Node rear;

    public bool IsEmpty => front == null;

    public void enqueue(int value)
    {
      Node node = new Node(value);
      rear.Next = node;
      rear = node;
    }
  }
}
