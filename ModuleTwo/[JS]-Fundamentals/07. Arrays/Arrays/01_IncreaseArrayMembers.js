/**
 * Created by Andrei on 1.6.2015 ã..
 */
var arr = new Array(20),
    i, len;

for (i = 0, len = arr.length; i < len; i += 1) {
    arr[i] = i * 5;
}

console.log(arr.join(', '));