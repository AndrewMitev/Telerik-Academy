var mongoose = require('mongoose');

var requiredMessage = '{PATH} is required';

module.exports.init = function() {
    var playlistSchema = mongoose.Schema({
        title: { type: String, required: requiredMessage},
        description: { type: String, required: requiredMessage},
        videoUrls: [String],
        category: {type: String, required: requiredMessage},
        creator: {type: String, required: requiredMessage},
        creationDate: {type: Date, required: requiredMessage},
        isPrivate: {type: Boolean, required: requiredMessage},
        comments: [{
            username: String,
            comment: String
        }],
        votesSum: {type: Number, default: 5},
        votesCount: {type: Number, default: 1}
    });

    playlistSchema.virtual('rating').get(function(){
        if (this.votesSum && this.votesCount) {
            return Number((this.votesSum / this.votesCount).toFixed(1));
        }

        return 'Not rated yet!';
    });

    var Playlist = mongoose.model('Playlist', playlistSchema);
};



