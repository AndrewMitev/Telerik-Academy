/**
 * Created by Andrei on 26.5.2015 ã..
 */
var input = document.getElementsByTagName("input");
var result = document.getElementsByTagName("h2");

var button = document.getElementsByTagName("button");

button[0].onclick = function() {
  if (input[0].value == 0 || (input[0].value | 0) % 2 == 0) {
      document.getElementById("first").innerHTML = "even";
  }
  else {
      document.getElementById("first").innerHTML = "odd";
  }
};
