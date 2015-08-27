var test = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>';


if (!String.prototype.bind) {
    String.prototype.bind = function (model) {
        var result;

        result = this.replace(/.*data\-bind\-content="(\w+)".*/g, function (match, firstGroup) {
            var index = match.indexOf('>');
            return match.slice(0, index + 1) + model[firstGroup] + match.slice(index + 1);
        });

        result = result.replace(/.*data\-bind\-href="(\w+)".*/g, function (match, firstGroup) {
            var index = match.indexOf('>');
            return match.slice(0, index) + ' href="' + model[firstGroup] + '"' + match.slice(index);
        });

        result = result.replace(/.*data\-bind\-class="(\w+)".*/g, function (match, firstGroup) {
            var index = match.indexOf('>');
            return match.slice(0, index) + ' class="' + model[firstGroup] + '"' + match.slice(index);
        });

        return result;
    };
}

console.log(test.bind({name: 'Elena', link: 'http://telerikacademy.com'}));