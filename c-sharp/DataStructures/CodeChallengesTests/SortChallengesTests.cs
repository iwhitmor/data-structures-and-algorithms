using System;
using Xunit;
using CodeChallenges.sorting;
using System.Linq;

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
      SortChallenges.SortInsertion(arr);

      //Assert
        Assert.Equal(new[] { 4, 8, 15, 16, 23, 42 }, arr);
    }

    [Theory]
    [InlineData(new[] { 1, 1, 1, 1 })]
    [InlineData(new[] { 4, 3, 2, 1 })]
    [InlineData(new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { -1, -2, -3, -4 })]
    public void SortInsertion_theory_test(int[] arr)
    {
      //Arrange
      int[] expected = arr.OrderBy(n => n).ToArray();

      //Act
      SortChallenges.SortInsertion(arr);

      //Assert
      Assert.Equal(expected, arr);
    }
  } 
}
