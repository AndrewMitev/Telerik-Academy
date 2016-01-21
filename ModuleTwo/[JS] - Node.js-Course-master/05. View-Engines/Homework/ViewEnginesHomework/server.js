var http = require('http');
var jade = require('jade');

var port = 1234;

http.createServer(function(request, response){

    var locals =['Home', 'SmartPhones', 'Tablets', 'Wearables'];
    response.writeHead({
        'Content-Type' : 'text/html'
    });

    if (request.url == '/home'){
        var fn = jade.compileFile('./views/home.jade', {pretty: true});
        var html = fn(locals);
        response.write(html);
    }

    if (request.url == '/smartphones') {
        var fn = jade.compileFile('./views/smart-phones.jade', {pretty: true});
        var html = fn(locals);
        response.write(html);
    }

    if (request.url == '/tablets') {
        var fn = jade.compileFile('./views/tablets.jade', {pretty: true});
        var html = fn(locals);
        response.write(html);
    }

    if (request.url == '/wearables') {
        var fn = jade.compileFile('./views/wearables.jade', {pretty: true});
        var html = fn(locals);
        response.write(html);
    }

    response.end();
}).listen(port);

console.log('Server running on port ' + port);
