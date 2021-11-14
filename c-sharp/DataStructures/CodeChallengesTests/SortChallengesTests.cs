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

    [Fact]
    public void MergeSort_is_working()
    {
      //Arrange
      int[] array = new int[10];
      array[0] = 53;
      array[1] = 20;
      array[2] = 4;
      array[3] = 101;
      array[4] = 75;
      array[5] = 70;
      array[6] = 55;
      array[7] = 34;
      array[8] = 1;
      array[9] = 43;

      //Act
      SortChallenges.MergeSort(array);

      //Assert
      Assert.Equal(new[] { 1, 4, 20, 34, 43, 53, 55, 70, 75, 101 }, array);
    }
  } 
}
