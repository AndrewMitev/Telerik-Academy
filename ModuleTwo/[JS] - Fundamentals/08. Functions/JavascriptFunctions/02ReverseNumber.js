    function Reverse(number) {
        var i, len, reversed = "";

        if(+number) {

            number = number.toString();

            for (len = number.length - 1, i = len; i >= 0; i -= 1) {
                reversed += number[i];
            }
        }

        return +reversed;
    }