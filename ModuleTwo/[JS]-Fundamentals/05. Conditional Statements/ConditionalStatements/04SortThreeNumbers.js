/**
 * Created by Andrei on 28.5.2015 ã..
 */
var a = -1.1,
    b = -0.5,
    c = -0.1;

if (a > b) {
    if (a > c) {
        console.log(a + " ");
            if(b > c) {
                console.log(b + " " + c);
            }
            else {
                console.log(c + " " + b);
            }
    }
    else {
        console.log(c + " " + a + " " + b);
    }
}
else {
    if (b > c) {
        console.log(b + " ");
        if(a > c) {
            console.log(a + " " + c);
        }
        else {
            console.log(c + " " + a);
        }
    }
    else {
        console.log(c + " " + b + " " + a);
    }
}