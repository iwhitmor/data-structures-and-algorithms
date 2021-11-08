# Sort Insertion

## Challenge Summary

* Using the pseudocode below, trace the algorithm by stepping through the process with the provided sample array. Document your explanation by creating a blog article that shows the step-by-step output after each iteration through some sort of visual.

* Sample Array

  * ```[8,4,23,42,16,15]```

## Approach & Efficiency

* Pseudo Code

  * ```InsertionSort(int[] arr)```

    ```FOR i = 1 to arr.length```

      ```int j <-- i - 1```
      ```int temp <-- arr[i]```

      ```WHILE j >= 0 AND temp < arr[j]```
        ```arr[j + 1] <-- arr[j]```
        ```j <-- j - 1```

      ```arr[j + 1] <-- temp```

## Solution
