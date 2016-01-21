var mongoose = require('mongoose'),
    encryption = require('../../utilities/encryption');

var requiredMessage = '{PATH} is required';
var defaultAvatar = 'http://static.comicvine.com/uploads/original/11125/111253442/4897645-batman.jpg';

module.exports.init = function() {
    var userSchema = mongoose.Schema({
        username: { type: String, required: requiredMessage, unique: true, validate: /^[A-z0-9_.]{6,20}$/},
        salt: String,
        hashPass: String,
        firstName: { type: String, required: requiredMessage},
        lastName: { type: String, required: requiredMessage},
        email: { type: String, required: requiredMessage},
        avatar: { type: String, default: defaultAvatar },
        rating: { type: Number, min: 1, max: 5},
        authorizedUsers: [String] //TODO: links to social media
    });

    userSchema.method({
        authenticate: function(password) {
            if (encryption.generateHashedPassword(this.salt, password) === this.hashPass) {
                return true;
            }
            else {
                return false;
            }
        }
    });

    var User = mongoose.model('User', userSchema);
};


