## Data Structures, Algorithms and Complexity Homework

1. What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the array's size is `n`.

  ```cs
  long Compute(int[] arr)
  {
      long count = 0;
      for (int i=0; i<arr.Length; i++) // n
      {
          int start = 0, end = arr.Length-1;
          while (start < end) // n / 2
              if (arr[start] < arr[end])
                  { start++; count++; }
              else 
                  end--;
      }
      return count;
  }
  ```
Algorithm complexity is `O(n^2)`
_______
2. What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row=0; row<matrix.GetLength(0); row++) // n
          if (matrix[row, 0] % 2 == 0) 
              for (int col=0; col<matrix.GetLength(1); col++) // m
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```

Algorithm complexity is `O(n * m)`
_______
3. (*) What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++) // n
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1); // m-1
      return sum;
  }
  
  Console.WriteLine(CalcSum(matrix, 0));
  ```
Algorithm complexity is `O(n * m)`