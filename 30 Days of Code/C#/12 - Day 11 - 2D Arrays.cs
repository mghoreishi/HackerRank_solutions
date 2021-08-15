//Day 11: 2D Arrays

static void Main(string[] args) 
{
  int[][] arr = new int[6][];

   for (int i = 0; i < 6; i++)
   {
      arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
   }

   int[] sum = new int[16];
   int hourglass = 0;
   for (int i = 0; i < 4; i++)
   {
     for (int j = 0; j < 4; j++)
     {
        sum[hourglass] = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                        + arr[i + 1][j + 1] 
                        + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
        hourglass++;
     }
    }
      Array.Sort(sum);
      Console.WriteLine(sum[15]);
}
