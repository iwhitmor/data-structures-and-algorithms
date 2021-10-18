using System;
using DataStructures;

namespace CodeChallenges
{
  public class PseudoQueue
  {
    Stack s1 = new Stack();
    Stack s2 = new Stack();

    void Enqueue(int value)
    {
      s1.push(value);
    }

    int Dequeue()
    {
      if (s2.IsEmpty)
      {
        while (!s1.IsEmpty)
        {
          s2.push(s1.Pop());
        }
        return s2.Pop();
      }
      return 0;
    }
  }
}
