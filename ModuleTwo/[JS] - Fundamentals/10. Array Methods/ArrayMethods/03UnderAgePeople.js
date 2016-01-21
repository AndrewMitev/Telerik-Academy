/** Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while) */

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

var people = GenerateArrayWithPersons(30);

var underAged = people.filter(
    function IsUnderAged(person) {
        return person.age < 18;
    }
);

//shows only people under 18
underAged.forEach(
    function ShowPerson(person) {
        console.log(person);
    }
);