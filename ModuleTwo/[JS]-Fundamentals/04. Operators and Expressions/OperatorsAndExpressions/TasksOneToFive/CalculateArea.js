/**
 * Created by Andrei on 27.5.2015 �..
 */
var width = document.getElementById("width");
var height = document.getElementById("height");

var button = document.getElementById("calculate");

button.onclick = function() {
    document.getElementById("third").innerHTML = width.value * height.value;
};