using System;
namespace DataStructures
{
  public class Queue
  {
    private Node front;
    private Node rear;

    public bool IsEmptyF => front == null;
    public bool IsEmptyR => rear == null;

    public void Enqueue(int value)
    {
      Node node = new Node(value);
      rear.Next = node;
      rear = node;
    }
  }
}
