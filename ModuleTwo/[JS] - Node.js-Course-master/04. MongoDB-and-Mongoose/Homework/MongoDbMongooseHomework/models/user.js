var mongoose = require('mongoose');

var userSchema = new mongoose.Schema({
    username: {type: String, required: true},
    password: String
});

var User = mongoose.model('User', userSchema);

module.exports = User;
