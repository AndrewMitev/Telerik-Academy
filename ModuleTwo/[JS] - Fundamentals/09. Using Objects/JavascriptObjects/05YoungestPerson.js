var youngest;
var people = [
    { firstname : 'John', lastname: 'Petrov', age:32 },
    { firstname : 'Bay', lastname: 'Ivan', age:81},
    { firstname: 'Sabrin', lastname: 'Lazarov', age:9}
];

function FindYoungest(array) {
    var person,
        youngest = array[0];

    for (person in array) {
        if (array[person].age < youngest.age) {
            youngest = array[person];
        }
    }

    return youngest;
}

youngest = FindYoungest(people);
console.log("Youngest person is " + youngest.firstname + " " + youngest.lastname);
