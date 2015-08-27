/**
 * Created by Andrei on 28.5.2015 ã..
 */
var number = document.getElementById("num");
var button = document.getElementsByTagName("button")[0];

button.onclick = function() {

        switch(number.value) {
            case "0": alert("Zero"); break;
            case "1": alert("One"); break;
            case "2": alert("Two"); break;
            case "3": alert("Three"); break;
            case "4": alert("Four"); break;
            case "5": alert("Five"); break;
            case "6": alert("Six"); break;
            case "7": alert("Seven"); break;
            case "8": alert("Eight"); break;
            case "9": alert("Nine"); break;
            default: alert("Not a number"); break;
        }
};
