/// <reference path="../bower_components/toastr/toastr.js" />
var validator = {
    validateIfUndefined: function (val, name) {
        name = name || 'Value';
        if (val === undefined) {
            toastr.error(name + ' cannot be undefined!');
        }
    },
    validateNonEmptyString: function (val, name) {
        name = name || 'Value';
        this.validateIfUndefined(val, name);
        if (typeof val !== 'string') {
            toastr.error(name + ' must be a string!');
        }
        if (val.trim(' ').length <= 0) {
            toastr.error(name + ' must be non empty string!');
        }
    },
    validateString: function (val, minLength, maxLength, name) {
        name = name || 'Value';
        this.validateIfUndefined(val, name);

        if (typeof val !== 'string') {
            toastr.error(name + ' must be a string!');
        }

        if (val.length < minLength || val.length > maxLength) {
            toastr.error(name + ' must be between ' + minLength + ' and ' + maxLength + ' symbols!');
        }

    },

    validateIfNumber: function (val, name) {
        name = name || 'Value';
        if (typeof val !== 'number') {
            toastr.error(name + ' must be a number!')
        }
    },
    validatePositiveNumber: function (val, name) {
        name = name || 'Value';
        this.validateIfUndefined(val, name);
        this.validateIfNumber(val, name);
        if (val < 0) {
            toastr.error(name + ' must be positive number!')
        }
    },

}