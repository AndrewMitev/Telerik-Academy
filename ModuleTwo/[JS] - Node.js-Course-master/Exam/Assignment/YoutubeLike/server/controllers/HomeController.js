var playlists = require('../data/playlists');

var CONTROLLER_NAME = 'home';

module.exports = {
    showTop: function(req, res) {
        playlists.getMostPopular(function(err, data){
            if (!err) {
                res.render('index', {
                    playlists: data
                });
            }
        });
    }
};
