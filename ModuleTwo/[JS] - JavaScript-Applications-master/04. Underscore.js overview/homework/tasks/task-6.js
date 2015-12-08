/* 
Create a function that:
*   **Takes** a collection of books
    *   Each book has propeties `title` and `author`
        **  `author` is an object that has properties `firstName` and `lastName`
*   **finds** the most popular author (the author with biggest number of books)
*   **prints** the author to the console
	*	if there is more than one author print them all sorted in ascending order by fullname
		*   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){

  function printAuthors(bestAuthorOrAuthors){
    if(bestAuthorOrAuthors.length === 1){
      console.log(bestAuthorOrAuthors[0]);
    }
    else{
      var sorted = _.sortBy(bestAuthorOrAuthors);
      _.each(sorted, function(item){
        console.log(item);
      });
    }
  }

  return function (books) {
    if(typeof require !== 'undefined'){
      _ = require('../bower_components/underscore/underscore.js');
    }

    var bestAuthorOrAuthors = [],
        bestCount = 0;

    var grouped = _.groupBy(books, function(book){
      return (book.author.firstName + ' ' + book.author.lastName);
    });

    _.each(grouped, function(group, index){
      if(group.length >= bestCount){
        bestCount = group.length;
        bestAuthorOrAuthors.push(index);
      }
    });

    printAuthors(bestAuthorOrAuthors);

  };
}

module.exports = solve;
