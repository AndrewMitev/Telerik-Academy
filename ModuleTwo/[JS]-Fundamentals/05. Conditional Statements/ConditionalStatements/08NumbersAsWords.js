/**
 * Created by Andrei on 31.5.2015 ã..
 */
var number = 999,
    hundreds,
    tens,
    digit,
    result = "";

if (Math.round(number / 100) != 0) {
    hundreds = Math.floor(number / 100);
    tens = Math.floor(number / 10) % 10;
    digit = number % 10;

    if (tens == 0 && digit == 0) {
        switch (hundreds) {
            case 1 :
                result += "One hundred"; break;
            case 2 :
                result += "Two hundred"; break;
            case 3 :
                result += "Three hundred"; break;
            case 4 :
                result += "Four hundred"; break;
            case 5 :
                result += "Five hundred"; break;
            case 6 :
                result += "Six hundred"; break;
            case 7 :
                result += "Seven hundred"; break;
            case 8 :
                result += "Eight hundred"; break;
            case 9 :
                result += "Nine hundred"; break;
            default :
                break;
        }
    }
    else {
        switch (hundreds) {
            case 1 :
                result += "One hundred and "; break;
            case 2 :
                result += "Two hundred and "; break;
            case 3 :
                result += "Three hundred and "; break;
            case 4 :
                result += "Four hundred and "; break;
            case 5 :
                result += "Five hundred and "; break;
            case 6 :
                result += "Six hundred and "; break;
            case 7 :
                result += "Seven hundred and "; break;
            case 8 :
                result += "Eight hundred and "; break;
            case 9 :
                result += "Nine hundred and "; break;
            default :
                break;
        }

        if (tens == 1) {
            switch (digit) {
                case 0 :
                    result += "ten"; break;
                case 1 :
                    result += "eleven"; break;
                case 2 :
                    result += "twelve"; break;
                case 3 :
                    result += "thirteen"; break;
                case 4 :
                    result += "fourteen"; break;
                case 5 :
                    result += "fifteen"; break;
                case 6 :
                    result += "sixteen"; break;
                case 7 :
                    result += "seventeen"; break;
                case 8 :
                    result += "eighteen"; break;
                case 9 :
                    result += "nineteen"; break;
            }
        }
        else {
            switch (tens) {
                case 0 :
                    break;
                case 1 :
                    break;
                case 2 :
                    result += "twenty";
                    break;
                case 3:
                    result += "thirty";
                    break;
                case 4:
                    result += "fourty";
                    break;
                case 5:
                    result += "fifty";
                    break;
                case 6:
                    result += "sixty";
                    break;
                case 7:
                    result += "seventy";
                    break;
                case 8:
                    result += "eighty";
                    break;
                case 9:
                    result += "ninety";
                    break;
            }

            switch(digit) {
                case 0 : break;
                case 1: result += " one"; break;
                case 2: result += " two"; break;
                case 3: result += " three"; break;
                case 4: result += " four"; break;
                case 5: result += " five"; break;
                case 6: result += " six"; break;
                case 7: result += " seven"; break;
                case 8: result += " eight"; break;
                case 9: result += " nine"; break;
            }
        }
    }
}
else if(Math.round(number / 10) != 0){
    tens = Math.floor(number / 10);
    digit = number % 10;

    if (tens == 1) {
        switch (number) {
            case 10 : result += "ten"; break;
            case 11 : result += "eleven"; break;
            case 12 : result += "twelve"; break;
            case 13 : result += "thirteen"; break;
            case 14 : result += "fourteen"; break;
            case 15 : result += "fifteen"; break;
            case 16 : result += "sixteen"; break;
            case 17 : result += "seventeen"; break;
            case 18 : result += "eighteen"; break;
            case 19 : result += "nineteen"; break;
        }
    }
    else {
        switch (tens) {
            case 1 : break;
            case 2 : result += "twenty"; break;
            case 3 : result += "thirty"; break;
            case 4 : result += "fourty"; break;
            case 5 : result += "fifty"; break;
            case 6 : result += "sixty"; break;
            case 7 : result += "seventy"; break;
            case 8 : result += "eighty"; break;
            case 9 : result += "ninety"; break;
        }

        switch (digit) {
            case 0 : break;
            case 1 : result += " one"; break;
            case 2 : result += " two"; break;
            case 3 : result += " three"; break;
            case 4 : result += " four"; break;
            case 5 : result += " five"; break;
            case 6 : result += " six"; break;
            case 7 : result += " seven"; break;
            case 8 : result += " eight"; break;
            case 9 : result += " nine"; break;
        }
    }
}
else if(number / 10 == 0){
    switch (number) {
        case 0 : result += "zero"; break;
        case 1 : result += "one"; break;
        case 2 : result += "two"; break;
        case 3 : result += "three"; break;
        case 4 : result += "four"; break;
        case 5 : result += "five"; break;
        case 6 : result += "six"; break;
        case 7 : result += "seven"; break;
        case 8 : result += "eight"; break;
        case 9 : result += "nine"; break;
    }
}

console.log(result);