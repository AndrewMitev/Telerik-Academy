var mongoose = require('mongoose');

module.exports = function(){
    mongoose.connect('mongodb://localhost:27017/tests');

    var db = mongoose.connection;

    db.once('open', function(err){
        if (err) {
            console.log(err);
        }

        console.log('Database up and running!');
    });

    db.on('error', function(err){
        console.log(err);
    });
}
