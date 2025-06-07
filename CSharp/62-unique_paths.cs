// url: https://leetcode.com/problems/unique-paths/
public class Solution {
    public int UniquePaths(int m, int n) {
        int[] currRow = new int[n];
        int[] prevRow = new int[n];
        currRow[0] = 1;

        for(int i = 0; i < m; i++) {
            currRow[0] = 1;

            for(int j = 1; j < n; j++) {
                currRow[j] = currRow[j-1] + prevRow[j];
            }

            prevRow = currRow;
        }

        return currRow[n-1]; 
    }
}
