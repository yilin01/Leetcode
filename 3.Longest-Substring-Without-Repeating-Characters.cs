public class Solution {
    public int LengthOfLongestSubstring(string s) {
      Dictionary<char, bool> dic = new Dictionary<char, bool>();
      int result =0;
      int leftIndex=0;
      int rightIndex =0;
      while(rightIndex<s.Length) {
        if(!dic.ContainsKey(s[rightIndex])) {
          dic.Add(s[rightIndex], true);
          rightIndex++;
          result= Math.Max(result, rightIndex-leftIndex);
        } else {
          dic.Remove(s[leftIndex]);
          leftIndex++;
        }
      }

      return result;
    }
}