/**
 * Created by Andrei on 3.6.2015 ã..
 */
var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    tempArr = [],
    i,
    j,
    counter,
    maxCount = 0,
    resultNum,
    len;

Array.prototype.contains = function (number) {
    var i,
        len = this.length;

    for (i = 0; i < len; i += 1) {
        if (this[i] == number) {
            return true;
        }
    }

    return false;
}

for(i = 0, len = arr.length; i < len - 1; i += 1) {
        if(!tempArr.contains(arr[i])) {
            tempArr.push(arr[i]);
            counter = 1;
            for (j = i + 1; j < len; j += 1) {
                if(arr[i] == arr[j]) {
                    counter += 1;
                }
            }

            if (maxCount < counter) {
                maxCount = counter;
                resultNum = arr[i];
            }
        }

}

console.log(resultNum + " (" + maxCount + " times)");