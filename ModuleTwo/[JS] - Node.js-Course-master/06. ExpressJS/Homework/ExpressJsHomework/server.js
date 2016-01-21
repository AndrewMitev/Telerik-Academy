var express = require('express'),
    mongoose = require('mongoose'),
    passport = require('passport'),
    BasicStrategy = require('passport-http').BasicStrategy,
    Plane = require('./models/plane').Plane,
    port = 8111;

var entry = ['Login', 'Register', 'AddPlane', 'CreatePlane', 'UpdatePlane', 'DeletePlane'];

passport.use(new BasicStrategy(
    function(username, password, done) {
        User.findOne({ username: username }, function (err, user) {
            if (err) { return done(err); }
            if (!user) { return done(null, false); }
            if (!user.validPassword(password)) { return done(null, false); }
            return done(null, user);
        });
    }
));

var app = express();

app.set('view engine', 'jade');

app.get('/', function(request, response){
    var allPlanes = Plane.find();

    response.render('all-planes', allPlanes);
});

app.get('/register', function(request, response){
    response.render('register', {entries: entry});
});

app.get('/login', function(request, response){
    response.render('login', {entries: entry});
});

app.get('/addplane', function(request, response){
    response.render('add-plane');
});

app.post('/addplane', passport.authenticate('basic', {session:false}), function(request, response){
    var newPlane = new Plane({
        name: request.body.name,
        torque: request.body.torque
    });

    newPlane.save(function(err){
        if (err) console.log(err);
    });
});



app.listen(port);

console.log('Server running on port ' + port);