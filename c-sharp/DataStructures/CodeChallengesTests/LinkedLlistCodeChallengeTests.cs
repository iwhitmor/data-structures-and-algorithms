using System;
using CodeChallenges;
using DataStructures;
using Xunit;

namespace CodeChallengesTests
{
  public class LinkedLlistCodeChallengeTests
  {
    [Fact]
    public void ZipTwoLists_with_two_empty_lists()
    {
      //Arrange
      LinkedList list1 = new LinkedList();

      LinkedList list2 = new LinkedList();

      //Act
      LinkedList result = LinkedListChallenges.ZipTwoLists(list1, list2);

      //Assert
      Assert.Empty(result);
    }
  }
}
