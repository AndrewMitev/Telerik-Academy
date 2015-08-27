function DeepCopy(obj) {
    if (typeof(obj) !== 'object') {
        return obj;
    }

    var cloned = {};

    for (var i in obj) {
        cloned[i] = DeepCopy(obj[i]);
    }

    return cloned;
}

var andy = { age: 21, family: "mitev"};
var cloning = DeepCopy(andy);

andy.i = 22;

console.log(andy);
console.log(cloning);