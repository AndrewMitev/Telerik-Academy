require('./config/mongoose')();
var User = require('./models/user');
var Message = require('./models/message');

function registerUser(entryModel){
    var newUser = new User();
    newUser.username = entryModel.user;
    newUser.password = entryModel.password;
    newUser.save(function(err, student){
        if (err) {
            console.log(err);
        }

        console.log('Student ' + student.username + ' saved to database!');
    });
}

function sendMessage(entryModel){

    if(!User.find({'username': entryModel.from})){
        console.log('Sending user doesn\'t exist');
        return;
    }

    if(!User.find({'username': entryModel.to})){
        console.log('Destination user doesn\'t exist');
        return;
    }

    var newMessage = new Message();
    newMessage.from = entryModel.from;
    newMessage.to = entryModel.to;
    newMessage.text = entryModel.text;
    newMessage.save(function(err, message){
        console.log('Message sent!');
    });
}

function getMessages(entryModel){
     Message.find()
        .or([{from: entryModel.with, to: entryModel.and}, {from: entryModel.and, to: entryModel.with}])
        .exec(function(err, results){
            console.log(results);
        });
}

module.exports = {
    registerUser: registerUser,
    sendMessage: sendMessage,
    getMessages: getMessages
};