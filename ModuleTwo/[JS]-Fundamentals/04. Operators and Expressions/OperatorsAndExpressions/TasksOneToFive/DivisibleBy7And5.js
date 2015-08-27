/**
 * Created by Andrei on 27.5.2015 ã..
 */
var number = document.getElementsByTagName("input")[1];

var button = document.getElementById("checkInteger");

button.onclick = function() {
    if (+number.value) {
        if (number.value % 5 ==0 && number.value % 7 == 0) {
            document.getElementById("second").innerHTML = true;
        }
        else {
            document.getElementById("second").innerHTML = false;
        }
    }
    else {
        alert("Please, enter number!");
    }
};