function FindWord(text, word, caseSensitive) {
    var index,
        count = 0;

    switch(arguments.length) {
        case 1: break;
        case 2: caseSensitive = true; break;
    }

    if(!caseSensitive) {
        text = text.toLowerCase();
        word = word.toLowerCase();
        console.log(word);
    }
    console.log(word);
    index = text.indexOf(word);

    if(index != -1) {
        count = 0;
        while(index != -1) {
            index = text.indexOf(word, index + 1);
            count += 1;
        }
    }

    return count;
}
console.log(FindWord("bacon bndy is lalala ndnsakjde Bacon","Bacon"));