function solve(args) {
    var array = args.filter(isNotWhitespace),
        wantedArray = [];

    function isNotWhitespace(element) {
        if (element && element != '\n') {
            return element.trim();
        }
    }

    function RemoveSemi(array) {
        var newArr = [],
            startPosition = array.indexOf('}') - 1;
        array[startPosition] = array[startPosition].replace(';', '');

        while (true) {

            startPosition = array.indexOf('}', startPosition + 2);

            if (startPosition == -1) {
                break;
            }
            array[startPosition - 1] = array[startPosition - 1].replace(';', '');
        }

        return array;
    }

    Array.prototype.contains = function(item) {
        var length = this.length,
            i;

        for (i = 0; i < length; i += 1) {
            if (this[i] == item) {
                return true;
            }
        }

        return false;
    }
    String.prototype.replaceAll = function(old, newC) {
        var newString = '',
            j,
            length = this.length;

        for (j = 0; j < length; j++) {
            if (this[j] == old) {
                newString += newC;
            }
            else {
                newString += this[j];
            }
        }

        return newString;
    }

    array = array.map(
        function(element) {
            return element.replaceAll(' ', '').replaceAll('\t', '').replaceAll('\n', '');
        }
    );

    for (var i = 0; i < array.length; i += 1) { //merge selectors
        if (!wantedArray.contains(array[i]) && array[i] !== '}') {
            wantedArray.push(array[i]);
        }
        else if(wantedArray.contains(array[i]) && array[i] !== '}') {

            var wantedIndex = wantedArray.indexOf(array[i]),
                insertIndex = wantedArray.indexOf('}', wantedIndex + 1);
                outerIndex = array.indexOf('}', i);

            while (i < outerIndex) {

                i += 1;
                wantedArray.splice(insertIndex, 0, array[i]);
            }
        }

        if (array[i] == '}') {
            wantedArray.push(array[i]);
        }


    }
    console.log([2,1,2,3,4].slice(1,1));
    wantedArray = RemoveSemi(wantedArray);
    console.log(wantedArray.join(''));
}

solve([
    'haha',
    'sds;',
    '}'
]);

//solve([
//    'font{',
//    'eho;',
//    '}',
//    'font{',
//    'nana;',
//    '}'
//]);
//solve([
//'#the-big-b{',
//    'color: yellow;',
//    'size: big;',
//'}',
//'.muppet{',
//    'powers: all;',
//    'skin: fluffy;',
//'}',
//'.water-spirit         {',
//    'powers: water;',
//    'alignment    : not-good;',
//'}',
//'all{',
//    'meant-for: nerdy-children;',
//'}',
//'.muppet      {',
//    'powers: everything;',
//'}',
//'all            .muppet {',
//    'alignment             :             good                             ;',
//'}',
//'.muppet+             .water-spirit{',
//    'power: everything-a-muppet-can-do-and-water;',
//'}'
//
//]);