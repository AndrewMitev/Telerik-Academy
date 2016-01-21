/** Write a function that calculates the average age of all females, extracted from an array of persons
 * Use Array#filter
 * Use only array methods and no regular loops (for, while) */

function GenerateArrayWithPersons(numPersons) {
    return Array.apply(null, new Array(numPersons))
        .map(
        function(_, index) {
            return {
                firstname: 'Peson ' + index,
                lastname: 'Unknown ' + index,
                age: 10 + index,
                gender: !!(index % 2)
            };
        }
    );
}

var people = GenerateArrayWithPersons(5);

function AverageAgeOfWomen(array) {
    var females = array.filter(
        function(person) {
            return person.gender;
        }
    );
    console.log('----Women-----');
    console.log(females);
    console.log('---------');
    var age = 0,
        count = females.length;

    females.forEach(
        function(female) {
            age += female.age;
        }
    );

    return Math.round(age / count);
}

console.log(AverageAgeOfWomen(people));