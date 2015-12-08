var templates = (function () {

    var handlebars = window.handlebars || window.Handlebars;

    function get(name) {
        var url = 'js/templates/' + name + '.html';
        var promise = new Promise(function (resolve, reject) {
            $.get(url, function (html) {
                var template = handlebars.compile(html);
                resolve(template);
            }).error(function (err) {
                reject(err);
            });
        });
        return promise;
    }

    return {
        get: get
    }
}());