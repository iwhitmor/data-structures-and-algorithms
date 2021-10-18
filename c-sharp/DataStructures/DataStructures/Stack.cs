using System;
namespace DataStructures
{
  public class Stack
  {
    private Node top;

    public bool IsEmpty => top == null;

    public void Push(int value)
    {
      Node node = new Node(value);
      node.Next = top;
      top = node;
    }

    public int Peek()
    {
      if (top == null)
      {
        throw new InvalidOperationException();
      }
        else return top.Value;
    }

    public int Pop()
    {
      Node temp = top;
      top = top.Next;
      temp.Next = null;

      return temp.Value;
    }
  }
}
