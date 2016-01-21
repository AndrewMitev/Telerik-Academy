/**
 * Write a function that finds the youngest male person in a given array of people and prints his full name
 * Use only array methods and no regular loops (for, while)
 * Use Array#find
 * */
if(!Array.prototype.find) {
    Array.prototype.find = function(predicate) {
        if (this == null) {
            throw new TypeError("Array.prototype.find called with null value or undefined");
        }

        if (typeof predicate !== 'function') {
            throw  new TypeError('Predicate must be function!');
        }

        var i,
            length = this.length;

        for (i = 0; i < length; i += 1) {
            if(predicate(this[i], i, this)) {
                return this[i];
            }
        }

        return undefined;
    }
}

var people = [
    {firstname: 'Georgi', lastname: 'Damianov', age: 21, gender: false},
    {firstname: 'Mihail', lastname: 'Stoyanov', age: 17, gender: false},
    {firstname: 'Stoyan', lastname: 'Bonev', age: 100, gender: false},
    {firstname: 'Cecka', lastname: 'Cacheva', age: 60, gender: true}
];

var youngest = people
    .sort(
    function(a, b) {
        return a.age - b.age;
    }
)
    .find(
    function(person) {
        return !person.gender;
    }
);

console.log('Name: ' + youngest.firstname + ' Last Name: ' + youngest.lastname);