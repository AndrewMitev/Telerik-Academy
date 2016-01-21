Array.prototype.CheckIfLargerThanNeighbours = function (position) {
    if (position > 0 && position < this.length - 1) {
        if ( (this[position] > this[position - 1]) && (this[position] > this[position + 1])) {
            return true;
        }
    }
    else if(position == 0 && this.length > 1) {
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

function FirstLargerThanNeighbours(array) {
    var i,
        len = array.length;

    for (i = 0; i < len; i += 1) {
        if(array.CheckIfLargerThanNeighbours(i)) {
            return array[i];
        }
    }

    return -1;
}

console.log(FirstLargerThanNeighbours([2,3,4,5,11,2,32,1]));
console.log(FirstLargerThanNeighbours([2,2,2]));
console.log(FirstLargerThanNeighbours([0]));