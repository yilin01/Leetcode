public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
      int[] result = new int[];
      int[] prefix = new int[nums.Length];
      int[] suffix = new int[nums.Length];
      System.Array.Fill(prefix, 1);
      System.Array.Fill(suffix, 1);
      for (int i=1; i< nums.Length; i++) {
        prefix[i] = prefix[i-1] * nums[i-1];
      }

      for (int i=nums.Length-1-1; i>=0 ; i--) {
        suffix[i] = suffix[i+1] * nums[i+1];
      }

      for(int i=0; i<nums.Length; i++) {
        result[i] = prefix[i] * suffix[i];
      }

      return result;

    }
}


// public class Solution {
//     public int[] ProductExceptSelf(int[] nums) {
//       int[] result = new int[nums.Length];
//       int totoalProduct = 1;
//       int countOfZero=0;
//       int indexOfFirstZero=-1;
//       for(int i=0; i< nums.Length; i++) {
//         if(nums[i] == 0) {
//           countOfZero++;
//           indexOfFirstZero = i;
//         } else {
//           totoalProduct *=nums[i];
//         }
//       }
      
//       if(countOfZero >1 ) {
//         System.Array.Fill(result, 0);        
//       } else if(countOfZero ==1) {
//         System.Array.Fill(result, 0);        
//         result[indexOfFirstZero] = totoalProduct;
//       } else {
//         for (int i=0; i<nums.Length; i++) {
//           result[i] = totoalProduct/nums[i];
//         }
//       }

//       return result;

//     }
// }