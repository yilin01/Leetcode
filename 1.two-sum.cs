using System; 
using System.Collections.Generic;   
/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();
        for ( int i=0; i<nums.Length; i++) {
            int key = target - nums[i];
            if (!dic.ContainsKey(key)) {
                dic.Add(key, i);
            }
        }
        for(int i=0; i<nums.Length; i++) {
            if(dic.ContainsKey(nums[i])){
                return new int[] { i, dic[nums[i]] };
            }
        }
        return new int[];
    }
}
// @lc code=end

