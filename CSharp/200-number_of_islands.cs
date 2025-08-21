// url: https://leetcode.com/problems/number-of-islands/description/
public class Solution {
    public int NumIslands(char[][] grid) {
        int result = 0;    

        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[0].Length; j++) {
                if(grid[i][j] == '1') {
                    result += 1;
                    dfs(grid, i, j);
                }
            }
        }

        return result;
    }

    private void dfs(char[][] grid, int i, int j) {
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] != '1') {
            return;
        }

        grid[i][j] = '0';

        dfs(grid, i-1, j);
        dfs(grid, i+1, j);
        dfs(grid, i, j-1);
        dfs(grid, i, j+1);
    }
}
