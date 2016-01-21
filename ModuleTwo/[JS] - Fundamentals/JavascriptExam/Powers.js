/**
 * Created by Andrei on 11.6.2015 ã..
 */
function solve(params) {
    var nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number),
        result = 0,
        n = +nk[0],
        k = +nk[1],
        wantedArray = [],
        i,
        j;

    while(true) {
        for (i = 0; i < n; i += 1) {
            if (s[i] === 0) {
                if (i == 0) {
                    wantedArray.push(Abs(s[n - 1] - s[1]));
                }
                else if (i == n - 1) {
                    wantedArray.push(Abs(s[n - 2] - s[0]));
                }
                else {
                    wantedArray.push(Abs(s[i - 1] - s[i + 1]));
                }
            }

            if(s[i] === 1) {
                if (i == 0) {
                    wantedArray.push(s[n - 1] + s[1]);
                }
                else if (i === n - 1) {
                    wantedArray.push(s[n - 2] + s[0]);
                }
                else {
                    wantedArray.push(s[i - 1] + s[i + 1]);
                }
            }

            if(s[i] !== 0 && s[i]!== 1 && s[i] % 2 !== 0) {
                if (i == 0) {
                    wantedArray.push(Min(s[n - 1], s[1]));
                }
                else if (i === n - 1) {
                    wantedArray.push(Min(s[n - 2], s[0]));
                }
                else {
                    wantedArray.push(Min(s[i - 1], s[i + 1]));
                }
            }

            if(s[i] !== 0 && s[i]!== 1 && s[i] % 2 == 0) {
                if (i == 0) {
                    wantedArray.push(Max(s[n - 1], s[1]));
                }
                else if (i === n - 1) {
                    wantedArray.push(Max(s[n - 2], s[0]));
                }
                else {
                    wantedArray.push(Max(s[i - 1], s[i + 1]));
                }
            }


        }//for

        s = wantedArray;

        wantedArray = [];

        k -= 1;
        if (k === 0) {
            break;
        }
    }

    var length = s.length;
    for (j = 0; j < length; j += 1) {
        result += s[j];
    }

    function Max(a, b) {
        if (a > b) {
            return a;
        }
        else {
            return b;
        }
    }

    function Min(a, b) {
        if (a < b) {
            return a;
        }
        else {
            return b;
        }
    }

    function Abs(a) {
        if(a < 0) {
            return -1 * a;
        }
        else {
            return a;
        }
    }

    console.log(result);
}