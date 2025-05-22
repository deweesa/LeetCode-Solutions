// url: https://leetcode.com/problems/coin-change/
public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var counts = new int[amount + 1];

        Array.Fill(counts, amount+1);
        counts[0] = 0;

        foreach(var coin in coins) {
            if(coin <= amount) {
                counts[coin] = 1;
            }
        }

        for(var i = 1; i <= amount; i++) {
            foreach(var coin in coins) {
                if(coin > i) continue;
                counts[i] = Math.Min(counts[i], counts[i-coin]+1);
            }
        }

        return counts[amount] == amount + 1 ? -1 : counts[amount];
    }
}
