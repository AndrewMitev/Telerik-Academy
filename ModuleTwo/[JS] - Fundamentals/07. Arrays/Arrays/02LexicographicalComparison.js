/**
 * Created by Andrei on 1.6.2015 ã..
 */
var i, len;

Array.prototype.compare = function(arr) {

    len = Math.min(this.length, arr.length);

    for(i = 0; i < len; i += 1) {
        if (this[i] !== arr[i]) {
            return this[i] < arr[i] ? -1 : 1;
        }
    }

    return 0;
}

console.log(['a', 'b', 'c'].compare(['a', 'b', 'c']));
console.log(['a', 'b', 'c'].compare(['a', 'c', 'b']));
console.log(['a', 'c', 'b'].compare(['a', 'b', 'c']));