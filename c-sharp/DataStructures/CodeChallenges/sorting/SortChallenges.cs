using System;
namespace CodeChallenges.sorting
{
  public class SortChallenges
  {
    public static void SortInsertion(int[] arr)
    {

      for (int i = 1; i < arr.Length; i++)

      {

        int j = i - 1;

        int temp = arr[i];

        while (j >= 0 && temp < arr[j])

        {

          arr[j + 1] = arr[j];
            j = j - 1;

        }

        arr[j + 1] = temp;

      }
    }

    public static void MergeSort(int[] array)
    {
      int n = array.Length;

      if (n > 1)
      {
        int mid = (n / 2);
        int[] left = new int[mid];
        int[] right = new int[n-mid];

        Array.Copy(array, left, mid);
        Array.Copy(array, mid, right, 0, right.Length);

        MergeSort(left);
        MergeSort(right);

        Merge(left, right, array);
      }
    }

    public static void Merge(int[] left, int[] right, int[] array)
    {
      int i = 0;
      int l = 0;
      int r = 0;

      while (l < left.Length && r < right.Length)
      {
        if (left[i] <= right[l])
        {
          array[r] = left[i];
        }
        else
        {
          array[r] = right[l];

          l++;
        }

        r++;
      }
      if (i == left.Length)
      {
        array[i] = right[i];
      }
      else
      {
        array[i] = left[i];
      }
    }
  }
}