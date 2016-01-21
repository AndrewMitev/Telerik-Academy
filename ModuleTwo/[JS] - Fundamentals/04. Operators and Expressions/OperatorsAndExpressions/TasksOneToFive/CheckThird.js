/**
 * Created by Andrei on 27.5.2015 ã..
 */
var number = document.getElementById("thirdNumber");
var button = document.getElementById("checkThirdDigit");
var result = document.getElementById("fourth");

button.onclick = function() {
    if (number.value.length == 3 && +number.value) {
        if (Math.floor(number.value / 100) == 7) {
            result.innerHTML = true;
        }
        else {
            result.innerHTML = false;
        }
    }
    else if (number.value.length > 3 && +number.value) {
        if (Math.floor((number.value / 100) % 10) == 7) {
            result.innerHTML = true;
        }
        else {
            result.innerHTML = false;
        }
    }
    else {
        result.innerHTML = false;
    }
};
