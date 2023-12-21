public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        //Declare scores for a, b
        int alic=0;
        int bob=0;
        
        for(int i=0;i<a.Count;i++)
        {
            if (a[i] > b[i])
            {
                alic++;
            }
            else if (a[i]<b[i])
            {
                bob++;
            }
        }
        //create a list to hold the scores
        List<int> result= new List<int> {alic,bob};
        return result;
    }
