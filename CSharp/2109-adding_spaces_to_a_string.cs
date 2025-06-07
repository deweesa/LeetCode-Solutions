// url: https://leetcode.com/problems/adding-spaces-to-a-string/description/
public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        StringBuilder sb = new StringBuilder(s.Length + spaces.Length);

        int strPtr = 0;
        int spacePtr = 0;

        for(int i = 0; i < s.Length; i++) {
            if(spacePtr != spaces.Length && i == spaces[spacePtr]) {
                sb.Append(' ');
                spacePtr++;
            }

            sb.Append(s[i]);
        }

        return sb.ToString();
    }
}
