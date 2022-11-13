using System.Collections.Generic;
public class Solution {

  public static void Main() {
    Dictionary<int, Int64> dic = new Dictionary<int, Int64>();    
    int n = 5;
    Int64 result = fib(n, dic);
    Console.WriteLine("the result for fib of {0} = {1}", n, result);
  }

  public static Int64 fib(int n, Dictionary<int, Int64> dic) {
    if(n<=2) return 1;
    if(dic.ContainsKey(n)) return dic[n];
    Int64 dpResult = fib(n-1, dic) + fib(n-2, dic);
    dic.Add(n, dpResult);

    return dpResult;
  }

}