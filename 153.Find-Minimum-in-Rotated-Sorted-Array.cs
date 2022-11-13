public class Solution {
    public int FindMin(int[] nums) {      

      return findMin(0, nums.Length-1, nums);        

    }
    public int findMin(int startIndex, int endIndex, int[] nums) {
      int midIndex = startIndex + (endIndex-startIndex)/2;
      if(startIndex==endIndex) {
        return nums[startIndex];
      } else if(endIndex - startIndex ==1) {
        return System.Math.Min(nums[startIndex], nums[endIndex]);
      }
      if(nums[midIndex]>nums[startIndex] && nums[midIndex]>nums[endIndex]) {
        return findMin(midIndex, endIndex, nums);
      } else {
        return findMin(startIndex, midIndex, nums);
      }
    }
}