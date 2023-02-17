namespace data.Leetcode.SlidingWindows;

public class FruitIntoBasket
{
    public int main(int[] trees)
    {
        int max=0;
        var map = new Dictionary<int, bool>();
        var start = 0;
            
        for (var end = 0; end < trees.Length; end++)
        {
            var item = trees[end];
            if (map.Count < 2 && !map[item])
            {
                map[item] = true;
                max = (int)Math.Max((double)max,(double)end-start+1);
            }else if (map[item])
            {
                max = (int)Math.Max((double)max,(double)end-start+1);
            }
            else
            {
                map = new Dictionary<int, bool>();
                map[trees[end - 1]] = true;
                map[item] = true;
                start = end - 1;
                while (trees[start] == trees[start - 1])
                {
                    start--;
                }
                max = (int)Math.Max((double)max,(double)end-start+1);
            }
        }

        return (int)max;
    }
}