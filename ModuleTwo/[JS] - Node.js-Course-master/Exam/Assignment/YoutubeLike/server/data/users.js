var User = require('mongoose').model('User');

module.exports = {
    create: function(user, callback) {
        User.create(user, callback);
    },
    findUser: function(id, callback){
        User
            .findOne({'_id' : id})
            .exec(function(err, user){
                if (err){
                    console.log(err);
                    return;
                }

                callback(err, user);
            });
    }
};