// url: https://leetcode.com/problems/group-anagrams/
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();

        foreach(string s in strs) {
            string key = String.Concat(s.OrderBy(c => c));
            if(!dict.ContainsKey(key)) 
                dict[key] = new List<string>();
            dict[key].Add(s);
        }

        return dict.Values.ToList();
    }
}
