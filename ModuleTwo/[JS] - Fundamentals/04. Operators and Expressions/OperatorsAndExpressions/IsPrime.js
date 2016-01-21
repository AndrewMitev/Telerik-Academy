/**
 * Created by Andrei on 28.5.2015 ã..
 */
var prime = 97, notPrime = 51;

console.log(IsPrime(prime));
console.log(IsPrime(notPrime));

function IsPrime(number) {
    if(number < 0) {
        return false;
    }

    for (var i = 2; i < Math.sqrt(number); i++) {
        if (!(number % i)) {
            return false;
        }
    }

    return true;
}