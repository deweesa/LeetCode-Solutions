// url: https://leetcode.com/problems/pacific-atlantic-water-flow/description/
public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        int[,] pacificVisited = new int[heights.Length,heights[0].Length];
        int[,] atlanticVisited = new int[heights.Length,heights[0].Length];

        for(int i = 0; i < heights.Length; i++) {
            dfs(heights, pacificVisited, i, 0, 0);
            dfs(heights, atlanticVisited, i, heights[0].Length-1, 0);
        }

        for(int j = 0; j < heights[0].Length; j++) {
            dfs(heights, pacificVisited, 0, j, 0);
            dfs(heights, atlanticVisited, heights.Length-1, j, 0);
        }

        List<IList<int>> result = new List<IList<int>>();

        for(int i = 0; i < heights.Length; i++) {
            for(int j = 0; j < heights[0].Length; j++) {
                if(pacificVisited[i,j] == 1 && atlanticVisited[i,j] == 1) {
                    result.Add(new List<int>() {i,j});
                }
            }
        }

        return result;
    }

    public void dfs(int[][] heights, int[,] visited, int i, int j, int prevHeight) {
        if(!IsValid(heights, i, j) || visited[i,j] != 0) return;  
        if(heights[i][j] < prevHeight) return; 

        visited[i,j] = 1;

        dfs(heights, visited, i-1, j, heights[i][j]);
        dfs(heights, visited, i+1, j, heights[i][j]);
        dfs(heights, visited, i, j-1, heights[i][j]);
        dfs(heights, visited, i, j+1, heights[i][j]);
    }

    public bool IsValid(int[][] heights, int i, int j) {
        if(i < 0 || i >= heights.Length) return false;
        if(j < 0 || j >= heights[0].Length) return false;
        return true;
    }
}
