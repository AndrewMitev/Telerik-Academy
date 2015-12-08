var cookiesController = function () {
    var $content = $('#content');

    function all() {
        var cookies;
        data.cookies.all()
            .then(function (res) {
                cookies = res.result;
                return templates.get('cookies');
            })
            .then(function (template) {
                $content.html(template(cookies));
            });
    }

    function add(context) {
        templates.get('cookies-add')
                 .then(function (template) {
                     $content.html(template())

                     $('#btn-add-cookie').on('click', function () {
                         var title = $('tb-cookie-text').val();
                         var category = $('tb-cookie-category').val();
                         data.cookies.add(title, category)
                             .then(function () {
                                 context.redirect('#/cookies');
                             });
                     });
                 });
    }

    return {
        all: all,
        add: add
    }
}();