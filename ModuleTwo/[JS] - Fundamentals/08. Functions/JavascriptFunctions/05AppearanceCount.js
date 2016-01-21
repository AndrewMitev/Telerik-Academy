Array.prototype.NumberOfOccurance = function (number) {
    var i,
        len = this.length,
        count = 0;

    for(i = 0; i < len; i += 1) {
        if (this[i] == number) {
            count += 1;
        }
    }

    return count;
}

function TestFunction() {
    arr = [2, 1, 2, 2, 4 , 5, 2, 1, 2.34, 12, 2,98];

    console.log(arr.NumberOfOccurance(1));
    console.log(arr.NumberOfOccurance(2));
    console.log(arr.NumberOfOccurance(0));
    console.log(arr.NumberOfOccurance(1.01));
    console.log(arr.NumberOfOccurance("hah"));

}

TestFunction();