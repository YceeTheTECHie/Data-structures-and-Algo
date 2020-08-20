
// Question: You are given an array of numbers [1,2,4,5,7,2,8] ,
// Find the number that occurs more than once in the array

var repeatednum = [1,2,4,5,7,2,8].sort((a,b) =>{ return a > b});
for (let i =0;i < repeatednum.length;++i){
    if (repeatednum[i] == repeatednum[i+1])
    console.log( repeatednum[i] + " is repeated")
}
return;
