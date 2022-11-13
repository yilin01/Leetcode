public class Solution {
    public int CoinChange(int[] coins, int amount) {
      int[] dp = new int[amount+1];
      System.Array.Fill(dp, amount+2);

      for(int i=1; i<=amount; i++) {
        for(int j=0; j<coins.Length; j++) {
          if(i>=coins[j]){
            dp[i] = System.Math.Min(dp[i], 1 + dp[i-coins[j]]);
          }
        }
      }

      return dp[amount] > amount ? -1 : dp[amount];
        
    }
}