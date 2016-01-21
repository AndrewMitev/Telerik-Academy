Array.prototype.remove = function (param) {
    for(var position in this) {
        if (this[position] === param) {
            this.splice(position, 1);
        }
    }
}

var arr = [2, 3, 4, 5, 6, 7, 9];
arr.remove(3);
console.log(arr.join(", "));