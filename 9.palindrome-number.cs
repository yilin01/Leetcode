/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0) return false;

        string reversedStr = Reverse(x.ToString());
        int result;
        int.TryParse(reversedStr, out result);

        return result == x;
        
    }

    private string Reverse(string str) {
        int midIndex = (str.Length+1)/2 - 1;
        int strLen = str.Length;
        char[] arrChars = str.ToCharArray();
        for(int i=0; i<= midIndex; i++ ) {
            char temp = arrChars[i];
            arrChars[i] = arrChars[strLen -1 - i];
            arrChars[strLen -1 - i] = temp;
        }

        return new string(arrChars);
    }
}
// @lc code=end

