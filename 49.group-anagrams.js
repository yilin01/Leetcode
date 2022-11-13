/**
 * @param {string[]} strs
 * @return {string[][]}
 */
 var groupAnagrams = function(strs) {
    var map = new Map();
    strs.forEach((elm) => {
      var sortedElm = elm.split('').sort().join('');
      var mapValue = map.get(sortedElm);
      if(mapValue !== undefined) {
        mapValue.push(elm);
        map.set(sortedElm, mapValue);
      } else {
        var newValue = [];
        newValue.push(elm);
        map.set(sortedElm, newValue);
      }
    })

    var result = [];
    for (let mapvalue of map.values()) {
      result.push(mapvalue);
    }

    return result;
};

var strs = ["eat","tea","tan","ate","nat","bat"];
console.log(groupAnagrams(strs));

