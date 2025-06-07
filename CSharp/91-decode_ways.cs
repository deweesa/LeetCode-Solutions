// url: https://leetcode.com/problems/decode-ways/
public class Solution {
    public int NumDecodings(string s) {
        if(s[0] == '0') return 0;
        if(s.Length == 1) return 1;

        int[] ways = new int[s.Length + 1];
        ways[1] = 1;
        ways[0] = 1;

        for(int i = 2; i <= s.Length; i++) {
            if(s[i-1] != '0') {
                ways[i] += ways[i-1];
            }

            if(IsValid(s[i-2], s[i-1])) {
                ways[i] += ways[i-2];
            }
        }

        return ways[s.Length]; 
    }

    private bool IsValid(char a, char b) {
        if(a == '0') return false;
        if(a > '2') return false;
        if(a == '2' && b > '6') return false;
        return true;
    }
}
