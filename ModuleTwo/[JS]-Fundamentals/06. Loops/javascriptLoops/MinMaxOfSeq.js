/**
 * Created by Andrei on 28.5.2015 ã..
 */
var arr = [21, 2, 3, 55, 2, -2, 8],
    i, len,
    max = Number.MIN_VALUE;
    min = Number.MAX_VALUE;

for (i = 0, len = arr.length; i < len; i += 1) {
    if (arr[i] > max) {
        max = arr[i];
    }

    if (arr[i] < min) {
        min = arr[i];
    }
}

console.log("Max element is:" + max);
console.log("Min element is:" + min);
