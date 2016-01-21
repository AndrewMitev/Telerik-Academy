/**
 * Created by Andrei on 28.5.2015 ã..
 */
var a = 5.5,
    b = 4.5;

if(a > b) {
    a += b;
    b = a - b;
    a -= b;
}

console.log(a + " " + b);
