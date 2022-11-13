public class Solution {
    public int MaxProfit(int[] prices) {
        int leftIndex = 0;
        int rightIndex = 1;
        int MaxProfile = 0;

        while (rightIndex < prices.Length) {
          if (prices[rightIndex] - prices[leftIndex] > MaxProfile) {
            MaxProfile = prices[rightIndex] - prices[leftIndex] > MaxProfile 
              ? prices[rightIndex] - prices[leftIndex] : MaxProfile;
            rightIndex++;
          } else {
            leftIndex = rightIndex;
          }
        }
        return MaxProfile;
    }
}