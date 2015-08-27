/**
 * Created by Andrei on 28.5.2015 ã..
 */
var i,
    N = 21237;

for (i = 1; i <= N; i += 1) {
    if(i % 3 == 0 && i % 7 == 0) {
        console.log(i);
    }
}