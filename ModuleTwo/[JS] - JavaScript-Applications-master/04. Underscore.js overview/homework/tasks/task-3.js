/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName`, `age` and `marks` properties
        *   `marks` is an array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (students) {
    if(typeof require !== 'undefined'){
      _ = require('../bower_components/underscore/underscore.js');
    }

    var topStudent = _.sortBy(students, function(student){
      var average = student.marks.reduce(function(sum, el){
        return sum = (sum + el);
      }, 0);

      return average / student.marks.length;
    });

    var averageGrade;
    topStudent = _.first(topStudent.reverse());

    averageGrade = _.reduce(topStudent.marks, function(sum, mark){
      return sum += mark;
    }, 0) / topStudent.marks.length;

    console.log(topStudent.firstName + ' ' + topStudent.lastName + ' has an average score of ' + averageGrade);
  };
}

module.exports = solve;
