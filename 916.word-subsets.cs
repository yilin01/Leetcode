/*
 * @lc app=leetcode id=916 lang=csharp
 *
 * [916] Word Subsets
 */

// @lc code=start
using System.Linq;
public class Solution {
    public IList<string> WordSubsets(string[] words1, string[] words2) {
        int[] bWordFrequence = getBWordsCharFrequeuce(words2);
        System.Collections.Generic.Ilist<string> result = new System.Collections.Generic.List<string>();
        foreach (string word in words1) {
            int[] wordCharFrequence = getCharFrequence(word);
            bool isSubset = true;
            for (int i=0; i< 26; i++) {
                if (bWordFrequence[i] > wordCharFrequence[i]) {
                    isSubset = false;
                    break;
                }
            }
            if(isSubset) result.Add(word);
        }

        return result;
    }

    public int[] getBWordsCharFrequeuce(string[] BWords) {
        int[] result = new int[26];
        foreach(string word in BWords) {
            int[] tempResult = getCharFrequence(word);
            for(int i=0; i< 26; i++) {
                if(tempResult[i] > result[i]) {
                    result[i] = tempResult[i];
                }
            }
        }
        return result;
    }
    public int[] getCharFrequence(string word) {
        int[] charFrequence = new int[26];
        foreach (char c in word.ToCharArray()) {
            charFrequence[c - 'a']++;
        }
        return charFrequence;
    }
}
// @lc code=end

