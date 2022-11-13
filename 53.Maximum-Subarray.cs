public class Solution {
    public int MaxSubArray(int[] nums) {
      int sum = nums[0];
      int curSum = 0;
      for (int i=0; i< nums.Length; i++) { 
        if(curSum<0) curSum =0;
        curSum += nums[i];       
        sum = System.Math.Max(sum, curSum);
      }
      return sum;        
    }
}