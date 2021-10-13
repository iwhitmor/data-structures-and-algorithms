using System;
namespace DataStructures
{
  public class Program
  {
    public static void Main(string[] args) 
    {
      LinkedList ll = new LinkedList();
      ll.KthFromEnd(2);

      Console.WriteLine(ll);
    }
  }
}
