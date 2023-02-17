namespace data.Leetcode;

public class GroupAnagram
{
    public IList<IList<string>> GroupAnagrams(string[] strs) {
            var result = new List<IList<string>>();
            var added = new HashSet<int>();
            for (int i = 0; i < strs.Length; i++) {
      
                if (added.Contains(i)) {
                    continue;
                }
                var group = new List<string> { strs[i] };
                added.Add(i);
                for (int j = i+1; j < strs.Length; j++) {
                    //cek apakah string index ke j apakah sudah masuk ke grup
                    if (added.Contains(j)) {
                        continue;
                    }
                    if (IsAnagram(strs[i], strs[j])) {
                        group.Add(strs[j]);
                        added.Add(j);
                    }
                }
                result.Add(group);
            }
            return result;
        }
    
        private bool IsAnagram(string s1, string s2) {
            var s1Chars = s1.ToCharArray();
            Array.Sort(s1Chars);
            var s2Chars = s2.ToCharArray();
            Array.Sort(s2Chars);
            return new string(s1Chars) == new string(s2Chars);
        }
  
}