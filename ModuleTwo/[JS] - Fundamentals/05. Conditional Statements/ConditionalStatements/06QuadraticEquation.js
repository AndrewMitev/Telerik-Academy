/**
 * Created by Andrei on 28.5.2015 ã..
 */
var a = 2,
    b = 5,
    c = -3,
    x1, x2;

if ( (Math.pow(b, 2) - 4 * a * c) < 0) {
    console.log("no real roots");
}
else {
    x1 = (-b + Math.round(Math.sqrt(Math.pow(b, 2) - 4 * a * c))) / (2 * a);
    x2 = (-b - Math.round(Math.sqrt(Math.pow(b, 2) - 4 * a * c))) / (2 * a);

    console.log("x1 = " + x1 + " x2 = " + x2);
}

