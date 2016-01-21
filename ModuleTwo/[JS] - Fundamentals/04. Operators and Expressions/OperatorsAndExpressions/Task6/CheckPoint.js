/**
 * Created by Andrei on 28.5.2015 ã..
 */
var x = document.getElementById("x");
var y = document.getElementById("y");
var button = document.getElementById("checkPoint");

button.onclick = function() {
    if( (Math.pow(x.value, 2) + Math.pow(y.value, 2)) < Math.pow(5, 2)) {
        document.getElementById("first").innerHTML = true;
    }
    else {
        document.getElementById("first").innerHTML = false;
    }
};

