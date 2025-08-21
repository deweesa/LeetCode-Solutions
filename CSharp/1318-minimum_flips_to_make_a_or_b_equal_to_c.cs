/* https://leetcode.com/problems/minimum-flips-to-make-a-or-b-equal-to-c/description/?envType=study-plan-v2&envId=leetcode-75
 * Given 3 positives numbers a, b and c. Return the minimum flips required in some bits of a and b to make ( a OR b == c ). (bitwise OR operation).
 * Flip operation consists of change any single bit 1 to 0 or change the bit 0 to 1 in their binary representation.
 */

public class Solution {
    public int MinFlips(int a, int b, int c) {
        int count = 0;

        while(a != 0 || b != 0 || c != 0) {
            if(((a & 1) | (b & 1)) != (c & 1)) {
                if(((a & 1) == (b & 1)) && (c & 1) == 0) count += 2;
                else count += 1;
            }
            a = a >> 1;
            b = b >> 1;
            c = c >> 1;
        }

        return count;
    }
}
