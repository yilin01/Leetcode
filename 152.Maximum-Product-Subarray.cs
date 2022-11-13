public class Solution {
    public int MaxProduct(int[] nums) {

      int curMax =1;
      int curMin =1;
      int result = int.MinValue;
      for (int i=0; i< nums.Length; i++) {
        int tempCurMax = curMax;
        int tempCurMin = curMin;
        curMax = System.Math.Max(System.Math.Max(tempCurMax * nums[i], tempCurMin*nums[i]), nums[i]);
        curMin = System.Math.Min(System.Math.Min(tempCurMax * nums[i], tempCurMin*nums[i]), nums[i]);
        result = System.Math.Max(result, curMax);
      }

      return result;
        
    }
}