Array.prototype.CheckIfLargerThanNeighbours = function (position) {
    if (position > 0 && position < this.length - 1) {
        if ( (this[position] > this[position - 1]) && (this[position] > this[position + 1])) {
            return true;
        }
    }
    else if(position == 0) {
        if (this[position] > this[position + 1]) {
            return true;
        }
    }
    else if (position == this.length - 1) {
        if (this[position] > this[position - 1]) {
            return true;
        }
    }

    return false;
}

var arr = [2, 3, 1, 2, 4, 11, 3];

console.log(arr.CheckIfLargerThanNeighbours(5)); //11
console.log(arr.CheckIfLargerThanNeighbours(4)); //4