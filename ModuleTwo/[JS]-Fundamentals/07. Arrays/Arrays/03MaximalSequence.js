/**
 * Created by Andrei on 3.6.2015 ã..
 */
var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 5, 5, 5, 5, 5, 5, 5],
    i,
    j,
    len,
    counter,
    maxSeq = Number.MIN_VALUE,
    number,
    output = "";

for (i = 0, len = arr.length; i < len - 1; i += 1) {
    counter = 1;
    j = i;
    while(arr[j] == arr[j +1]) {
        counter += 1;
        j += 1;
    }

    if (maxSeq < counter) {
        maxSeq = counter;
    }

    number = arr[i];
}


for(i = 0; i < maxSeq - 1; i += 1) {
    output += number + ",";
}

output += number;

console.log(output);