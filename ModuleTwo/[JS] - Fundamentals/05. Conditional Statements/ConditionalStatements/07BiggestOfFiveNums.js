/**
 * Created by Andrei on 31.5.2015 ã..
 */
var a = -3,
    b = -0.5,
    c =  -1.1,
    d = -2,
    e = -0.1;

if (a > b)  {
    if (a > c) {
        if (a > d) {
            if (a > e) {
                console.log("greatest number is " + a);
            }
            else {
                console.log("greatest number is " + e);
            }
        }
        else {
            if (d > e) {
                console.log("greatest number is " + d);
            }
            else {
                console.log("greatest number is " + e);
            }
        }
    }
    else {
        if (c > d) {
            if (c > e) {
                console.log("greatest number is " + c);
            }
            else {
                console.log("greatest number is " + e);
            }
        }
        else {
            if (d > e) {
                console.log("greatest number is " + d);
            }
            else {
                console.log("greatest number is " + e);
            }
        }
    }
}
else {
    if (b > c) {
        if (b > d) {
            if (b > e) {
                console.log("greatest number is " + b);
            }
            else {
                console.log("greatest number is " + e);
            }
        }
        else {
            if (d > e) {
                console.log("greatest number is " + d);
            }
            else {
                console.log("greatest number is  " + e);
            }
        }
    }
    else {
        if (c > d) {
            if (c > e) {
                console.log("greatest number is " + c);
            }
            else {
                console.log("greatest number is " + e);
            }
        }
        else {
            if (d > e) {
                console.log("greatest number is " + d);
            }
            else {
                console.log("greatest number is " + e);
            }
        }
    }
}