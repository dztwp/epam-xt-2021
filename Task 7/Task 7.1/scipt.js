function charRemover(){
let inputString=document.getElementById("input").value+"";
let separators=[" ","?","!",":",";",",","."]
let arr=splitStringBySeparators(inputString,separators);

for (let index = 0; index < inputString.length; index++) {
    if(arr.indexOf(inputString[index])!=arr.lastIndexOf(inputString[index])){
        inputString=removeSymbolFromString(inputString,inputString[index]);
    }   
}
document.getElementById("output").innerHTML=inputString+"";
}

function removeSymbolFromString(inputString,symbol){
    let ArrayOfSymbols=inputString.split("");
while (ArrayOfSymbols.indexOf(symbol)!=-1) {
    ArrayOfSymbols.splice(ArrayOfSymbols.indexOf(symbol),1);
    console.log(ArrayOfSymbols);
}
    return ArrayOfSymbols.join("");
}

function splitStringBySeparators(inString,separators){
    for (let index = 0; index < separators.length; index++) {
        inString = inString.split(separators[index]).join(""); 
    }
    return inString;
}