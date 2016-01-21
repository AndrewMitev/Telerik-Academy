/**
 * Created by Andrei on 28.5.2015 ã..
 */
var a = 0.222, b = 0.333, h = 0.555;

console.log(CalculateArea(a, b, h));

function CalculateArea(a, b, h) {
    return (((a + b) / 2) * h).toFixed(7);
}