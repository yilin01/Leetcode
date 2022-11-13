/**
 * @param {number} x
 * @return {number}
 */
 var reverse = function(x) {
    MAX_INT32 = 2147483647;
    MIN_INT32 = -2147483648;
    var isNegative = x < 0 ? true :false;
    var arrList = x.toString().split('');
    if (isNegative) arrList.splice(0,1);
    var reversedStr = arrList.reverse().join('');
    if(isNegative) reversedStr = '-' + reversedStr;

    var reversedInt = parseInt(reversedStr);
    if(reversedInt> MAX_INT32 || reversedInt < MIN_INT32) {
      return 0;
    } else {
      return reversedInt;
    }


};

var x = -1;
console.log(reverse(x));



// var reverse = function(x) {
//   MAX_INT32 = 2147483647;
//   MIN_INT32 = -2147483648;
//   var isNegative = x < 0 ? true :false;
//   var list = isNegative ? ['-'] : [];


//   var newX = x;
//   while (newX <= -10 || newX >= 10) {
//     var modValue = isNegative ?  (newX%10)*(-1) : (newX%10);
//     list.push(modValue); 
//     newX = Math.trunc(newX / 10);
//   }
//   var modValue = isNegative ?  (newX%10)*(-1) : (newX%10);
//   list.push(modValue); 

//   var reversedStr = list.join('');
//   var reversedInt = parseInt(reversedStr);
//   if(reversedInt> MAX_INT32 || reversedInt < MIN_INT32) {
//     return 0;
//   } else {
//     return reversedInt;
//   }


// };