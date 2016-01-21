var mongoose = require('mongoose');

var planeSchema = new mongoose.Schema({
    name: String,
    torque: Number
});

var Plane = mongoose.model('Plane', planeSchema);

module.exports.Plane = Plane;
