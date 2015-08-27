/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(x, y) {
    if (arguments.length < 2) {
        throw new Exception('function needs at least two parameters!');
    }
    else if (isNaN(arguments[0]) || isNaN(arguments[1])) {
        throw new Exception('Parameters must be numbers!');
    }

    var result = [],
        i,
        j,
        maxDivisor,
        isPrime;
    x = +x;
    y = +y;

    for (i = x; i <= y; i += 1) {
        maxDivisor = Math.sqrt(i);
        isPrime = true;

        for(j = 2; j <= maxDivisor; j += 1) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }

        if (isPrime && i > 1) {
            result.push(i);
        }
    }

    return result;
}

module.exports = findPrimes;
