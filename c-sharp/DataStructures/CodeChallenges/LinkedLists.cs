using System;
using DataStructures;

namespace CodeChallenges
{
  public static class LinkedListChallenges
  {
    public static LinkedList ZipTwoLists(LinkedList list1, LinkedList list2)
    {
      if (list1.Head == null)
        return list2;

      return list1;

    }
  }
}
