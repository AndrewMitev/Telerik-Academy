var options = {name: 'John'};

if (!String.prototype.format) {
    String.prototype.format = function (options) {
        var result = this.replace(/#{(\w+)}/g, function (match, matchGroup) {
            return options[matchGroup];
        });

        return result;
    };
}
console.log('Hello, there! Are you #{name}?'.format(options));
