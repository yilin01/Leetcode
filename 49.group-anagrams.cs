/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();
        IList<IList<string>> result = new List<IList<string>>();
        foreach (string str in strs) {
            Char[] chars = str.ToCharArray();
            Array.Sort(chars);
            String sortedStr = new String(chars);
            if(dic.ContainsKey(sortedStr)) {
                dic[sortedStr].Append(str);
            } else {
                dic.Add(sortedStr, new List<string>(){str});
            }
//            System.Console.WriteLine(string.Join(", ", dic[sortedStr]));
        }
        foreach(string key in dic.Keys) {
            System.Console.WriteLine(string.Join(", ", dic[key]));
            result.Append(dic[key]);
        }

        return result;
        
    }
}
// @lc code=end

