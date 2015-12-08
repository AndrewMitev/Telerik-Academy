function solve(){
    return function (students) {
        if(typeof require !== 'undefined'){
            _ = require('./bower_components/underscore/underscore.js');
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

var f = solve();
f([
    {

    }
]);

