function Calculate(){

    let inputedString = document.getElementById("Input").value+'';
    let reg=/^(((\s?\-?\d+(\.\d+)?)(\s?[\+,\*,\/,\-])?)+(\s?\=){1})?/gi;
    let arrOfSymbols=inputedString.match(reg).toString();

    if(arrOfSymbols[0]==""){
        console.log("Неправильно введено выражение")
    }
    else{
        arrOfSymbols=arrOfSymbols.split(' ').join('');

    }
    console.log(arrOfSymbols);

    let arrOfNumbers=GetArrOfNumbers(arrOfSymbols);
    let result=GetResult(arrOfNumbers)
    console.log(result);
    return result;
}

function GetResult(arrOfNumbers){
    let result=arrOfNumbers[0];
    for (let i = 1; i < arrOfNumbers.length-1; i+=2) {
        switch (arrOfNumbers[i]) {
            case '-':
                result=result-arrOfNumbers[i+1];               
                break;
            case '+':
                result=Number(result)+Number(arrOfNumbers[i+1]);               
                break;
            case '*':
                result=result*arrOfNumbers[i+1];               
                break; 
            case '*':
                result=result/arrOfNumbers[i+1];               
                break;        
            default:
                break;
        }
    }
    return result;
}

function GetArrOfNumbers(string){
    let arr=[];
    let tmpArr=[];
    for (let i = 0; i < string.length; i++) {
        
        if((string[i]=='-'||string[i]=='+'||string[i]=='*'||string[i]=='/') && i!=0){
            arr.push(tmpArr.toString().split(',').join(''));
            arr.push(string[i]);
            tmpArr=[];
        }
        else{
            tmpArr.push(string[i]);
        }      
    }
    return arr;
}