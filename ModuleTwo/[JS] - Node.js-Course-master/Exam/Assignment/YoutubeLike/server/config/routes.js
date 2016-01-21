var auth = require('./auth'),
    controllers = require('../controllers');

module.exports = function(app) {
    app.get('/register', controllers.users.getRegister);
    app.post('/register', controllers.users.postRegister);

    app.get('/login', controllers.users.getLogin);
    app.post('/login', auth.login);
    app.get('/logout', auth.logout);

    app.get('/', controllers.home.showTop);
    app.get('/profile', auth.isAuthenticated, controllers.users.showUser);

    app.get('/playlist', auth.isAuthenticated, controllers.playlists.show);
    app.post('/playlist', auth.isAuthenticated, controllers.playlists.create);

    app.get('/playlists', auth.isAuthenticated, controllers.playlists.getPlaylists);
    app.post('/date', auth.isAuthenticated, controllers.playlists.sortByDate);
    app.post('/categories', auth.isAuthenticated, controllers.playlists.searchByCategories);
    app.post('/title', auth.isAuthenticated, controllers.playlists.searchByTitleAndDescription);

    app.get('/playlists/details', auth.isAuthenticated, controllers.playlists.showDetails);
    app.post('/playlists/details', auth.isAuthenticated, controllers.playlists.addCommentRating);

    app.get('*', function(req, res) {
        res.redirect('/');
    });
};