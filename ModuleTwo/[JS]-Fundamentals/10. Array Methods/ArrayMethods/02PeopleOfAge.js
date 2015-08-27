/*Write a function that checks if an array of person contains only people of age (with age 18 or greater)
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

var arrayPersons = GenerateArrayWithPersons(8);
var oldPeople = [
    {firstname: 'Nana', lastname: 'Ivanova', age: 70, gender: false},
    {firstname: 'Simona', lastname: 'Teranovavova', age: 80, gender: false}
];

function CheckIfOfAge(array) {
    return array.every(
        function isOfAge(person) {
            return person.age >= 18;
        }
    );
}

console.log(CheckIfOfAge(arrayPersons)); //false
console.log(CheckIfOfAge(oldPeople)); //true