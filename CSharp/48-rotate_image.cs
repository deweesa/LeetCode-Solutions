// url: https://leetcode.com/problems/rotate-image/
public class Solution {
    public void Rotate(int[][] matrix) {
       int n = matrix.Count();
       Flip(matrix, n);
       Transpose(matrix, n); 
    }

    public void Flip(int[][] matrix, int n) {
        for(int i = 0; i < (n / 2); i++) {
            for(int j = 0; j < n; j++) {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[n-1-i][j];
                matrix[n-1-i][j] = temp;
            }
        }
    }

    public void Transpose(int[][] matrix, int n) {
        for(int i = 0; i < n; i++) {
            for(int j = i; j < n; j++) {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
    }
}
