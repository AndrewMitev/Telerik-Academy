/**
 * Created by Andrei on 28.5.2015 ã..
 */
//circle K( (1,1), 3)
//R(top=1, left=-1, width=6, height=2)

var x = -100, y = -100;

if (IsInCircle(x,y)) {
    console.log("Is it inside circle and outside rectangle? " + Boolean ((IsInCircle(x,y)^IsInRectangle(x, y))));
}
else {
    console.log("Is it inside circle and outside rectangle? false");
}

function IsInCircle(x, y) {
    if( (Math.pow((x - 1), 2) + Math.pow((y - 1), 2)) <= Math.pow(3, 2)) {
        return true;
    }

    return false;
}

function IsInRectangle(x, y) {
    if ( (x >= -1 && x <= 5) && (y <= 1) && y >= -1) {
        return true;
    }

    return false;
}