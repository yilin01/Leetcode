const dp={};
const fib=(n)=> {
  if(n <=2) return 1;
  if (dp[n] !==undefined) return dp[n];

  dp[n] = fib(n-1) + fib(n-2);
  return dp[n];
}

console.log(fib(50));