/**
 * Created by Andrei on 28.5.2015 ã..
 */
var number = document.getElementById("bit");
var button = document.getElementById("checkBit");

button.onclick = function () {
  document.getElementById("fifth").innerHTML = (number.value >> 3) & 1;
};