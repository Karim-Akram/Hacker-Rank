public static int diagonalDifference(List<List<int>> arr)
    {
         
         int LeftToRight=0;
         int RightToLift=0;
         int Lenght=arr.Count; //To get the multidimensional array length
         
         for (int i=0; i < Lenght; i++)
         {
             LeftToRight+=arr[i][i];
             RightToLift+=arr[i][Lenght-1-i];
         }
         
         int absoluteDifference=Math.Abs(LeftToRight - RightToLift);
         return absoluteDifference;
         
    } 
