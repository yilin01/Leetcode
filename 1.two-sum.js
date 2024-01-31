var twosum = function(num2, target) {
  const obj = {};
  for (var i=0; i< num2.length; i++) {
    if(obj[num2[i]] !== undefined) return [obj[num2[i]], i];
    obj[target-num2[i]] = i;
  }

}

var num2 = [2,7,5,15];
var target = 9;
console.log(twosum(num2, target));