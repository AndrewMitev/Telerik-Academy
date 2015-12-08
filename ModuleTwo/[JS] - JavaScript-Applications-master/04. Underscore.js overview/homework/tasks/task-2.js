/*
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName`, `lastName` and `age` properties
*   **finds** the students whose age is between 18 and 24
*   **prints**  the fullname of found students, sorted lexicographically ascending
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (students) {
    if(typeof require !== 'undefined'){
      _ = require('../bower_components/underscore/underscore.js');
    }

    var filtered = _.filter(students, function(student){
      return (student.age >= 18 && student.age <= 24);
    }).reverse();

    var sortedByName = _.sortBy(filtered, function(student){
      return student.firstName + ' ' + student.lastName;
    });

    _.each(sortedByName, function(student){
      console.log(student.firstName + ' ' + student.lastName);
    });
  };
}

module.exports = solve;
