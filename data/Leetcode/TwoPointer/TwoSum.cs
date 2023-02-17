namespace data.Leetcode.TwoPointer;

public class TwoSum
{
    public int[] main(int[] number,int target)
    {
       
        int left = 0;
        int rigth = number.Length - 1;
  
        while (left < rigth)
        {
            int sum = number[left] + number[rigth];
            if (sum == target)
            {
                return new int[] { left+1,rigth+1};
            }else if (sum < target)
            {
                left++;
            }
            else
            {
                rigth--;
            }
        }

        return new int[] { -1,-1 };
    

    }
}

/*
 * proses
 * input [1,2,3,4,5,6],target=6
 *pointer
 * [1,2,3,4,5,6]
 *  ^         ^ = 1+6=7;
 * 7 >6?
 * geser pinter kanan ke kiri
 * [1,2,3,4,5,6]
 *  ^       ^   = 1+5=6;
 */

