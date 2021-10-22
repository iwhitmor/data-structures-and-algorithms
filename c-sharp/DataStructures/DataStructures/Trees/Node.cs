using System;
namespace DataStructures.Trees
{
  public class Node<T>
  {
    public T Value { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }
  }
}
