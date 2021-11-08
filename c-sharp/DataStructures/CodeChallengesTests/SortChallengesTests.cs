using System;
using Xunit;
using CodeChallenges.sorting;

namespace CodeChallengesTests
{
  public class SortChallengesTests
  {
    [Fact]
    public void Sort_works()
    {

      //Arrange
      int[] arr = new int[6];
      arr[0] = 8;
      arr[1] = 4;
      arr[2] = 23;
      arr[3] = 42;
      arr[4] = 16;
      arr[5] = 15;

      //Act
      SortChallenges.Sort(arr);

      //Assert
        Assert.Equal(new[] { 4, 8, 15, 16, 23, 42 }, arr);
    }
  }
}
