var lastNumber,
    message;

function SayLastDigit(number) {
    if(+number) {
        lastNumber = number % 10;
        alert(lastNumber);
        switch(lastNumber) {
            case 0 : message = "zero"; break;
            case 1 : message = "one"; break;
            case 2 : message = "two"; break;
            case 3 : message = "three"; break;
            case 4 : message = "four"; break;
            case 5 : message = "five"; break;
            case 6 : message = "six"; break;
            case 7 : message = "seven"; break;
            case 8 : message = "eight"; break;
            case 9 : message = "nine"; break;
            default : message = "fatal error!"; break;
        }
    }
    else {
        alert("Not a digit!");
    }

    return message;
}