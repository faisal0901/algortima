namespace data.Leetcode.SlidingWindows;

public class MaxAvarageSubArray
{
    // public double main(int[] num,int k)
    // {
    //     // var max = double.NegativeInfinity;
    //     // for (int i = 0; i < num.Length; i++)
    //     // {
    //     //     var windowSum = 0;
    //     //     for (int j = 0; j < k; j++)
    //     //     {
    //     //         if (!(i + (k - 1) > num.Length - 1))
    //     //         {
    //     //             windowSum += num[i + j];
    //     //         }
    //     //         else
    //     //         {
    //     //             i = num.Length;
    //     //             j = k;
    //     //         }
    //     //     }
    //     //     if (windowSum !=0)
    //     //     {
    //     //         max = Math.Max(max, (double)windowSum / (double)k);
    //     //     }
    //     // }
    //     // if(max==double.NegativeInfinity)
    //     // {
    //     //     return 0;
    //     // }
    //     //
    //     // return max;
    // }
    public double main(int[] num,int k)
    {   
        var max = double.NegativeInfinity;
        int windowSum = 0;
        int start=0;
        for (int end = 0; end < num.Length; end++)
        {
            windowSum += num[end];
            if (end - start+1 == k)
            {
                
                //calculate avarage
                max = Math.Max(max, (float)windowSum / (float)k);
                windowSum -= num[start];
                start++;
            }
        }

        return max;
    }
}