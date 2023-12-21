 public static long aVeryBigSum(List<long> ar)
    {
        long sumofarr=0;
        for (int i=0; i < ar.Count; i++)
        {
            sumofarr=ar[i]+sumofarr;
        }        
        return sumofarr;

    }
