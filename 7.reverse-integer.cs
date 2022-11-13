/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
public class Solution {
    public int Reverse(int x) {
        bool isNegative = x < 0 ? true : false;

        System.Collections.ArrayList arrList = new System.Collections.ArrayList();

        int newX = x;
        int modValue;
        while ( newX>= 10 || newX <= -10) {     
            modValue = isNegative ? (newX % 10) * (-1) : (newX % 10);       
            arrList.Add(modValue);
            newX = newX/10;
        }
        modValue = isNegative ? (newX % 10) * (-1) : (newX % 10);       
        arrList.Add(modValue);

        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        if(isNegative) {
            sb.Append("-");
        }
        for (int i=0; i< arrList.Count; i++) {
            sb.Append(arrList[i]);
        }
        string reversedStr = sb.ToString();

        int result;
        int.TryParse(reversedStr, out result);        

        return result;
    }
}
// @lc code=end


// public class Solution {
//     public int Reverse(int x) {
//         bool isNegative = x < 0;
//         int absX = Math.Abs(x);
//         string stringX = absX.ToString();
//         string reversedStr = ReverseStr(stringX);
//         System.Console.WriteLine(reversedStr);
//         if (isNegative) {
//             reversedStr = '-' + reversedStr;
//         }
            
//         int result;
//         bool success = int.TryParse(reversedStr, out result);
//         if (success) {
//             return result;
//         } else {
//             return 0;
//         }
//     }

//     private string ReverseStr(string str) {
//         char[] strChars = str.ToCharArray();
//         int stringLen = strChars.Length;
//         int midIndex = (stringLen+1)/2 -1;
//         for (int i = 0; i <=midIndex; i++) {
//             char temp;
//             temp = strChars[i];
//             strChars[i] = strChars[stringLen - 1 - i];
//             strChars[stringLen - 1 - i] = temp;
//         }
//         return new string(strChars);
//     }
// }
