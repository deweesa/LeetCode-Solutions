/* url: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
 * description:   
 */
public class Solution {
    public int MaxProfit(int[] prices) {
        var lowest = Int32.MaxValue;
        var highest = lowest;
        var bestPrice = 0;

        for(int i = 0; i < prices.Length; i++) {
            var price = prices[i];

            if(price < lowest) {
                bestPrice = Math.Max(bestPrice, highest-lowest);
                lowest = highest = price;
            } else if(price > highest) {
                highest = price;
            }
        }

        return Math.Max(highest - lowest, bestPrice);
    }
}
