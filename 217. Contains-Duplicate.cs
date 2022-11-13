public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int,int> dic = new Dictionary<int, int>();
        foreach (int n in nums) {
            if(dic.ContainsKey(n)) {
                return true;
            } else {
                dic.Add(n, 1);
            }
        }
        return false;
        
    }
}