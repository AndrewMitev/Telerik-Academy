function solve(params) {
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]),
        i,
        j,
        move,
        player,
        playerDestination,
        field = [],
        tempArr = [],
        tempArrS = [],
        fieldSymbols = [],
        coords = [],
        resultString = '';

    for (i = 0; i < rows; i += 1) {

        for (j = 0; j < cols; j += 1) {

            symbol = String.fromCharCode(97 + j);

            tempArr.push(params[i + 2][j]);
            tempArrS.push(symbol + (rows - i));
        }

        field.push(tempArr);
        fieldSymbols.push(tempArrS);

        tempArr = [];
        tempArrS = [];
    }

    // fieldSymbol = symbols
    // field = values
    for (i = 0; i < tests; i++) {
        move = params[rows + 3 + i];

        coords = move.split(' ');

        var tempCoordsStart = getElementCoordinates(coords[0]);
        player = field[tempCoordsStart[0]][tempCoordsStart[1]];

        var tempCoordsEnd = getElementCoordinates(coords[1]);
        playerDestination = field[tempCoordsEnd[0]][tempCoordsEnd[1]];

        if (playerDestination !== '-') {
            console.log('no');
            continue;
        }

        switch (player) {
            case 'Q' :
                checkQueen(tempCoordsStart[0], tempCoordsStart[1]);
                break;
            case 'R' :
                checkRook(tempCoordsStart[0], tempCoordsStart[1]);
                break;
            case 'B' :
                checkBishop(tempCoordsStart[0], tempCoordsStart[1]);
                break;
            case '-' :
                console.log('no');
                break;
            default :
                break;
        }
    }

    function checkQueen(x, y) {
        moveUp(x, y);
        moveDown(x, y);
        moveLeft(x, y);
        moveRight(x, y);

        moveUpLeft(x, y);
        moveUpRight(x, y);
        moveDownLeft(x, y);
        moveDownRight(x, y);

        console.log(Boolean(resultString) ? 'yes' : 'no');

        resultString = '';
    }

    function checkRook(x, y) {
        moveUp(x, y);
        moveDown(x, y);
        moveLeft(x, y);
        moveRight(x, y);

        console.log(Boolean(resultString) ? 'yes' : 'no');

        resultString = '';
    }

    function checkBishop(x, y) {

        moveUpLeft(x, y);
        moveUpRight(x, y);
        moveDownLeft(x, y);
        moveDownRight(x, y);

        console.log(Boolean(resultString) ? 'yes' : 'no');

        resultString = '';
    }

    function getElementCoordinates(str) {
        var k, p;
        for (k = 0; k < rows; k += 1) {
            for (p = 0; p < cols; p += 1) {
                if (fieldSymbols[k][p] == str) {
                    return new Array(k, p);
                }
            }
        }
    }

    function moveUp(x, y) {
        x -= 1;

        if (x >= 0 && field[x][y] == '-') {
            if (x == tempCoordsEnd[0] && y == tempCoordsEnd[1]) {
                resultString = 'yes';
                return true;
            }

            moveUp(x, y);
        }
        else {
            return false;
        }
    }

    function moveDown(x, y) {
        x += 1;

        if (x < rows && field[x][y] == '-') {
            if (x == tempCoordsEnd[0] && y == tempCoordsEnd[1]) {
                resultString = 'yes';
                return true;
            }

            moveDown(x, y);
        }
        else {
            return false;
        }
    }

    function moveLeft(x, y) {
        y -= 1;

        if (y >= 0 && field[x][y] == '-') {
            if (x == tempCoordsEnd[0] && y == tempCoordsEnd[1]) {
                resultString = 'yes';
                return true;
            }

            moveLeft(x, y);
        }
        else {
            return false;
        }
    }

    function moveRight(x, y) {
        y += 1;
        if (y < cols && field[x][y] == '-') {
            if (x == tempCoordsEnd[0] && y == tempCoordsEnd[1]) {
                resultString = 'yes';
                return true;
            }

            moveRight(x, y);
        }
        else {
            return false;
        }
    }

    function moveUpLeft(x, y) {
        x -= 1;
        y -= 1;

        if (x >= 0 && y >= 0 && field[x][y] == '-') {
            if (x == tempCoordsEnd[0] && y == tempCoordsEnd[1]) {
                resultString = 'yes';
                return true;
            }

            moveUpLeft(x, y);
        }
        else {
            return false;
        }
    }

    function moveUpRight(x, y) {
        x -= 1;
        y += 1;

        if (x >= 0 && y < cols && field[x][y] == '-') {
            if (x == tempCoordsEnd[0] && y == tempCoordsEnd[1]) {
                resultString = 'yes';
                return true;
            }

            moveUpRight(x, y);
        }
        else {
            return false;
        }
    }

    function moveDownLeft(x, y) {
        x += 1;
        y -= 1;

        if (x < rows && y >= 0 && field[x][y] == '-') {
            if (x == tempCoordsEnd[0] && y == tempCoordsEnd[1]) {
                resultString = 'yes';
                return true;
            }

            moveDownLeft(x, y);
        }
        else {
            return false;
        }
    }

    function moveDownRight(x, y) {
        x += 1;
        y += 1;

        if (x < rows && y < cols && field[x][y] == '-') {
            if (x == tempCoordsEnd[0] && y == tempCoordsEnd[1]) {
                resultString = 'yes';
                return true;
            }

            moveDownRight(x, y);
        }
        else {
            return false;
        }
    }
}

//solve(
//    [
//        '5',
//        '5',
//        'Q---Q',
//        '-----',
//        '-B---',
//        '--R--',
//        'Q---Q',
//        '10',
//        'a1 a1',
//        'a1 d4',
//        'e1 b4',
//        'a5 d2',
//        'e5 b2',
//        'b3 d5',
//        'b3 a2',
//        'b3 d1',
//        'b3 a4',
//        'c2 c5'
//    ]);

//solve([
//    '3',
//    '4',
//    '--R-',
//    'B--B',
//    'Q--Q',
//    '12',
//    'd1 b3',
//    'a1 a3',
//    'c3 b2',
//    'a1 c1',
//    'a1 b2',
//    'a1 c3',
//    'a2 b3',
//    'd2 c1',
//    'b1 b2',
//    'c3 b1',
//    'a2 a3',
//    'd1 d3'
//]);