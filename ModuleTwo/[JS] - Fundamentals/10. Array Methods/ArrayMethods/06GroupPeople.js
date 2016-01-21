/**
 * Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 * Use Array#reduce
 * Use only array methods and no regular loops (for, while)
 */

var people = [
    {firstname: 'Georgi', lastname: 'Damianov', age: 21, gender: false},
    {firstname: 'Georgi', lastname: 'Milanov', age: 21, gender: false},
    {firstname: 'Mihail', lastname: 'Stoyanov', age: 17, gender: false},
    {firstname: 'Stoyan', lastname: 'Bonev', age: 100, gender: false},
    {firstname: 'Cecka', lastname: 'Cacheva', age: 60, gender: true}
];

console.log('Groups by first letter of first name');

var grouped = people.reduce(
    function(gr, person) {
        var letter = person.firstname[0];

        if (gr[letter]) {
            gr[letter].push(person);
        }
        else {
            gr[letter] = [person];
        }

        return gr;
    }
, {});

console.log(grouped);