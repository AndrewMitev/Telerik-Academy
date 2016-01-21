var Playlist = require('mongoose').model('Playlist'),
    constants = require('../common/constants');

var cache = {
    expires: undefined,
    data: undefined
};

module.exports = {
    create: function(playlist, callback) {
        Playlist.create(playlist, callback);
    },
    getAll: function(page,user, callback){
        Playlist
            .find({ $or: [{'isPrivate' : 'false'},{'creator': { $in : user.authorizedUsers}}]}) //Nightmare!
            .exec(function(err, foundPlaylists){
                if (err){
                    callback(err);
                    return;
                }

                Playlist
                    .find({ $or: [{'isPrivate' : 'false'},{'creator': { $in : user.authorizedUsers}}]})
                    .count()
                    .exec(function(err, total){
                        var data = {
                          playlists: foundPlaylists,
                          currentPage: page,
                          pageSize: constants.pageSize,
                          total: total
                        };

                        callback(err, data);

                        cache.data = data;
                        cache.expires = new Date() + 10;
                    });
            });
    },
    getMostPopular: function(callback){
        Playlist
            .find()
            .where({'isPrivate' : false})
            // TODO: sort
            .limit(8)
            .exec(function(err, data){

                callback(err, data);

                cache.data = data;
                cache.expires = new Date() + 10;
            });
    },
    sortByDate: function(callback){
        Playlist.find()
            .sort('-creationDate')
            .exec(function(err, sortedByDate){
                var data = {
                    playlists: sortedByDate,
                    currentPage: 1,
                    pageSize: constants.pageSize,
                    total: 10
                };

                callback(err, data);
            });
    },
    searchByCategories: function(page, categories, callback){
        page = page || 1;

        if (page == 1 && cache.expires && cache.expires < new Date()) {
            callback(null, cache.data);
            return;
        }

        Playlist.find()
            .where('category')
            .in(categories)
            .limit(constants.pageSize)
            .skip((page - 1) * constants.pageSize)
            .exec(function(err, sortedByDate){
                var data = {
                    playlists: sortedByDate,
                    currentPage: page,
                    pageSize: constants.pageSize,
                    total: 10
                };

                console.log('sorted by category ' + data.playlists);
                callback(err, data);
            });
    },
    searchByTitleAndDescription: function(page, searchString, callback){
        var params = searchString.split(' '),
            title = params[0],
            description = params[1];

        Playlist.find({
            title: title,
            description: description
        })
        .limit(constants.pageSize)
        .skip((page - 1) * constants.pageSize)
        .exec(function(err, sortedByDate){
                var data = {
                    playlists: sortedByDate,
                    currentPage: page,
                    pageSize: constants.pageSize,
                    total: 10
                };

                callback(err, data);
            });
    },
    findSpecific: function(id, callback){
        Playlist
            .findOne({ '_id' : id})
            .exec(callback);
    },
    updatePlaylist: function(id,username, comment, rating, callback){
        Playlist
            .findOne({ '_id' : id})
            .exec(function(err, playlist){
                if (comment) {
                    var comments = playlist.comments;
                    comments.push({
                        username: username,
                        comment: comment
                    });

                    playlist.update({
                        comments: comments
                    });
                }

                if (rating){
                    var votes = playlist.votesSum + Number(rating),
                        counts = playlist.votesCount + 1;

                    playlist.votesSum = votes;
                    playlist.votesCount = counts;

                    playlist.save();
                }

                callback(err, playlist);
            });
    }
};
