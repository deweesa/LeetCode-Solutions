/* https://leetcode.com/problems/decode-string/description/?envType=study-plan-v2&envId=leetcode-75
 * Given an encoded string, return its decoded string.
 * The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly k times. Note that k is guaranteed to be a positive integer.
 * You may assume that the input string is always valid; there are no extra white spaces, square brackets are well-formed, etc. Furthermore, you may assume that the original data does not contain any digits and that digits are only for those repeat numbers, k. For example, there will not be input like 3a or 2[4].
 * The test cases are generated so that the length of the output will never exceed 105.
 *
 * Example 1:
 * Input: s = "3[a]2[bc]"
 * Output: "aaabcbc"
 *
 * Example 2:
 * Input: s = "3[a2[c]]"
 * Output: "accaccacc"
 *
 * Example 3:
 * Input: s = "2[abc]3[cd]ef"
 * Output: "abcabccdcdcdef"
 *
 *
 */

public class Solution {
    public string DecodeString(string s) {
        var sb = new StringBuilder();
        var l = 0;

        while(l < s.Length) {
            if(!Char.IsNumber(s[l])){
                sb.Append(s[l]);
            } else {
                var endNum = s.IndexOf('[', l);
                var count = int.Parse(s.Substring(l, endNum - l));

                l = endNum + 1;
                var runner = l+1;
                var bracketCount = 1;

                while(bracketCount != 0) {
                    if(s[runner] == '[') bracketCount += 1;
                    else if(s[runner] == ']') bracketCount -= 1;
                    runner++;
                }

                var innerString = DecodeString(s.Substring(l, runner - l - 1));

                for(int i = 0; i < count; i++) {
                    sb.Append(innerString);
                }

                l = runner-1;
            }

            l++;
        }

        return sb.ToString();
    }
}
