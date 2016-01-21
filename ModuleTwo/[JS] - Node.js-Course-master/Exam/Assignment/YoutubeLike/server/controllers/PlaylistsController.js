var playlists = require('../data/playlists');

var CONTROLLER_NAME = 'playlists';

module.exports = {
    getPlaylists: function(req, res){
        var page = req.query.page || 1;
        playlists.getAll(page, req.user, function(err, data){
            res.render(CONTROLLER_NAME + '/playlists', {
                data: data
            });
        });
    },
    sortByDate: function(req, res){
       playlists.sortByDate(function(err, data){
           if (err){
               console.log(err);
               return;
           }

           res.render(CONTROLLER_NAME + '/playlists', {
               data: data
           });
       });
    },
    searchByCategories: function(req, res){
        var categories = req.body.categories,
            page = req.query.page;


        playlists.searchByCategories(page, categories, function(err, data){
            if (err){
                console.log(err);
                return;
            }

            res.render(CONTROLLER_NAME + '/playlists', {
                data: data
            });
        });
    },
    searchByTitleAndDescription: function(req, res){
        var searchString = req.body.searchString,
            page = req.query.page;


        playlists.searchByTitleAndDescription(page, searchString, function(err, data){
            if (err){
                console.log(err);
                return;
            }

            res.render(CONTROLLER_NAME + '/playlists', {
                data: data
            });
        });
    },
    showDetails: function(req, res){
        var id = req.query.id;

        playlists.findSpecific(id, function(err, playlist){
            if (err){
                console.log(err);
                return;
            }

            res.render(CONTROLLER_NAME + '/details', {
                playlist: playlist
            });
        })
    },
    addCommentRating: function(req, res){
        var id = req.query.id,
            username = req.user.username,
            comment = req.body.comment,
            rating = req.body.rating;

        playlists.updatePlaylist(id,username, comment, rating, function(err, playlist){
            if (err){
                console.log(err);
                req.session.error = err;
                return;
            }

            res.render(CONTROLLER_NAME + '/details', {
                playlist: playlist
            });
        });
    },
    show: function(req, res){
        res.render(CONTROLLER_NAME + '/newPlaylist');
    },
    create: function(req, res){
        var user = req.user;

        var newPlaylist = {
            title: req.body.title,
            description: req.body.description,
            category: req.body.category,
            isPrivate: Boolean(req.body.isPrivate),
            creator: user.username,
            creationDate: new Date(),
            videoUrls: ['default', 'defaultTwo'],
            comments: [{
              username: 'None',
              comment: 'Strange'
            }],
            votesSum: 0,
            votesCount: 0
        };

        playlists.create(newPlaylist, function(error, newPlay){
            if (error){
                console.log(error);
                req.session.error = 'Could not add playlist! ' + error;
                res.redirect('/playlists');
            }

            req.session.successMessage = 'Playlist added!';
            res.redirect(CONTROLLER_NAME);
        });
    }
};
