var mongoose = require('mongoose');

var userSchema = new mongoose.Schema({
    username: String,
    password: String
});

var User = mongoose.model('User', userSchema);

module.export.User = User;

module.exports.findByUsername = function(username, cb) {
    process.nextTick(function() {
        var user = User.find({username: username});

        if(user) {
            return cb(null, user);
        }

        return cb(null, null);
    });
}
