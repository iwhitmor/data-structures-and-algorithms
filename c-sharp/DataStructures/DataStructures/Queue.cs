using System;
using DataStructures.Trees;

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

    public int Peek()
    {
      if (front == null)
      {
        throw new InvalidOperationException();
      }
      else return front.Value;
    }

    public int Dequeue()
    {
      Node temp = front;
      front = front.next;
      temp.Next = null;

      return temp.Value;
    }
  }
}