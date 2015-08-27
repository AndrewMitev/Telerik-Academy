/**
 * Created by Andrei on 3.6.2015 ã..
 */
var arr = [3, 21, 1, 7, 92, 22],
    tempArr = [],
    i,
    j,
    swap,
    len;

for (i = 0, len = arr.length; i < len - 1; i += 1) {
    for (j = i + 1; j < len; j++) {
        if (arr[i] > arr[j]) {
            swap = arr[i];
            arr[i] = arr[j];
            arr[j] = swap;
        }
    }
}

console.log(arr.join(", "));