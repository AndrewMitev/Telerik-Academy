var templates = (function(){
    var handlebars = window.handlebars || window.Handlebars,
        cache = {};

    function get(templateName){
        var promise = new Promise(function(resolve, reject){
            if(cache[templateName]){
                resolve(cache[templateName]);
                return;
            }

            var url = `templates/${templateName}.handlebars`;
            $.get(url, function(html){
                var template = handlebars.compile(html);
                cache[templateName] = template;
                resolve(template);
            });
        });

        return promise;
    }

    return {
        get: get
    };
}());
