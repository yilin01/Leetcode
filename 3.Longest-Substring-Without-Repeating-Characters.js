/**
 * @param {string} s
 * @return {number}
 */
 var lengthOfLongestSubstring = function(s) {
  var result=0;
  var dic = {};
  var leftIndex = 0;
  var rightIndex = 0;
  while(rightIndex<s.length) {
    if(!dic[s[rightIndex]]) {
      dic[s[rightIndex]] = true;
      rightIndex++;
      result = Math.max(result, rightIndex-leftIndex);
    } else {
      dic[s[leftIndex]] = false;
      leftIndex++
    } 
  }
  return result;
    
};

console.log(lengthOfLongestSubstring('pwwkew'))


// var lengthOfLongestSubstring = function(s) {
//   var result=0;
//   var dic = {};
//   var leftIndex = 0;
//   var rightIndex = 1;
//   dic[s[leftIndex]] = 1;
//   var curLength = 1;
//   while(rightIndex<s.length ) {
//     console.log(`letter=${s[rightIndex]}`);
//     if(dic[s[rightIndex]]>0) {
//       console.log(`1-dic[s[rightIndex]]=${dic[s[rightIndex]]}, curLength=${curLength}, leftIndex=${leftIndex}`);
//       dic[s[rightIndex]]--
//       curLength--;
//       leftIndex++;      
//     } else {
//       console.log(`2-dic[s[rightIndex]]=${dic[s[rightIndex]]}, curLength=${curLength}, leftIndex=${leftIndex}`);
//       dic[s[rightIndex]] = dic[s[rightIndex]]===undefined ? 1 : dic[s[rightIndex]] +1;
//       curLength++;
//       rightIndex++
//       result = Math.max(result, curLength);
//     }
//   }

//   return result;
    
// };
