// url: https://leetcode.com/problems/clone-graph/description/
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    private Dictionary<int, Node> visited;

    public Solution() {
        visited = new Dictionary<int, Node>();
    }

    private Node Helper(Node node) {
        if(node == null) {
            return node;
        }

        if(visited.ContainsKey(node.val)) {
            return visited[node.val];
        }

        var copy_node = new Node(node.val);
        visited.Add(node.val, copy_node);

        foreach(var neighbor in node.neighbors) {
            copy_node.neighbors.Add(Helper(neighbor));
        }

        return copy_node;
    }

    public Node CloneGraph(Node node) {
        return Helper(node);
    }
}
