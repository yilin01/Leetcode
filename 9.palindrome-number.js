/**
 * @param {number} x
 * @return {boolean}
 */
 var isPalindrome = function(x) {
    if (x < 0) return false;

    var strX = x.toString();
    var reversedStr = strX.split('').reverse().join('');

    var result = parseInt(reversedStr);

    return result == x;

};