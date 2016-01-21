/**
 * Created by Andrei on 3.6.2015 ã..
 */
var arr = [3, 2, 3, 4, 2, 2, 4],
    i,
    j,
    len,
    counter,
    maxCount = 0,
    searchedNumber,
    output = "";

for (i = 0, len = arr.length; i < len - 1; i += 1) {
    j = i;
    counter = 1;

    while (arr[j] == arr[j + 1] - 1) {
        counter += 1;
        j += 1;
    }

    if (maxCount < counter) {
        maxCount = counter;
        searchedNumber = arr[i];
    }
}

for (i = 0; i < maxCount - 1; i += 1) {
    output += searchedNumber + ", ";
    searchedNumber += 1;
}

output += searchedNumber;

console.log(output);

