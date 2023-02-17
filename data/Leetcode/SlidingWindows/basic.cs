namespace data.Leetcode.SlidingWindows;

public class Basic
{
    public static void SlideWindows()
    {
        int[] data = new[] { 1,2,3,4,5,6,7,8,9};
        int k = 4;
        for (int i = 0; i <= data.Length - k; i++) {
            int[] subarray = new int[k];
            Array.Copy(data, i, subarray, 0, k);
            Console.Write("Subarray ke-" + (i+1) + ": ");
            foreach (int num in subarray) {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}