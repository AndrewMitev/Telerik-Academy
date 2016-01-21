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

var array = GenerateArrayWithPersons(10);

array.forEach(
    function (person) {
        console.log(person);
    }
);