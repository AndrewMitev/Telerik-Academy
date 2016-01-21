function hasProperty(obj, prop) {
    for (var property in obj) {
        if(property == prop) {
            return true;
        }
    }

    return  false;
}

var person = {
    name: 'sasho',
    age: 22
};

console.log(hasProperty(person, 'pop'));
console.log(hasProperty(person, 'name'));