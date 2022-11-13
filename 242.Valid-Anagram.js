/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
 var isAnagram = function(s, t) {
  var dic = {};

  for(var i=0; i< s.length; i++) {
    dic[s[i]] = (dic[s[i]] !== undefined) ? dic[s[i]]+1 : 1;
  }

  for(var i=0; i< t.length; i++) {
    dic[t[i]] = (dic[t[i]] !== undefined) ? dic[t[i]]-1 : -1;
  }

  var dicKeys = Object.keys(dic);
  for(var i=0; i< dicKeys.length; i++) {
    console.log(dic[dicKeys[i]]  );
    if(dic[dicKeys[i]] !==0) return false;
  }

  return true;

};

console.log(isAnagram('anagram', 'nagaram'));


// var isAnagram = function(s, t) {
//   sortedS = s.split('').sort().join('');
//   sortedT = t.split('').sort().join('');

//   return sortedS===sortedT;

// };