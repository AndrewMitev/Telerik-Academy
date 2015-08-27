/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/

function solve() {

    function getSortedAttributesString(attributes) {
        var attributesString = '',
            keys = [],
            key,
            i,
            len;

        for (key in attributes) {
            keys.push(key);
        }

        keys.sort();

        for (i = 0, len = keys.length; i < len; i += 1) {
            attributesString += ' ' + keys[i] + '="' + attributes[keys[i]] + '"';
        }

        return attributesString;
    }

    var domElement = (function() {
        var domElement = {
            init: function(type) {
                this.type = type;
                this.attributes = {};
                this.children = [];
                this.content = '';
                this.parent;

                return this;
            },
            appendChild: function(child) {
                this.children.push(child);

                if (typeof child === 'object') {
                    child.parent = this;
                }

                return this;
            },
            addAttribute: function(name, value) {
                var pattern = /^[A-Z\d\-]+$/ig;

                if (name.trim().length < 1) {
                    throw new Error("The name ot attribute must non-empty string!");
                }

                if (!(pattern.test(name))) {
                    throw new Error('The name must contains only Latin letters and digits or dashes -');
                }

                this.attributes[name] = value;

                return this;

            },
            removeAttribute: function(attribute) {
                if (!this.attributes[attribute]) {
                    throw new Error('This attribute does not exist.');
                }

                delete this.attributes[attribute];

                return this;
            },
            get type() {
                return this._type;
            },
            set type(value) {
                var pattern = /^[A-Z\d]+$/ig;
                if (value.trim().length === '') {
                    throw new Error('Type is invalid!');
                }

                if (!(pattern.test(value))) {
                    throw new Error('Type is invalid!');
                }

                this._type = value;
            },
            get content() {
                return this._content;
            },
            set content(value) {
                if (this.children.length) {
                    return '';
                }

                this._content = value;

            },
            get attributes() {
                return this._attributes;
            },
            set attributes(value) {
                this._attributes = value;
            },
            get children() {
                return this._children;
            },
            set children(value) {
                this._children = value;
            },
            get parent() {
                return this._parent;
            },
            set parent(value) {
                this._parent = value;
            },
            get innerHTML() {
                var innerHtml = '<' + this.type,
                    attributesString = getSortedAttributesString(this.attributes),
                    i,
                    len;

                innerHtml += attributesString + '>';

                var child;
                for (i = 0, len = this.children.length; i < len; i += 1) {
                    child = this.children[i];

                    if (typeof child === 'string') {
                        innerHtml += child;
                    } else {
                        innerHtml += child.innerHTML;
                    }
                }

                innerHtml += this.content;
                innerHtml += '</' + this.type + '>';

                return innerHtml;
            }
        };

        return domElement;
    }());

    return domElement;
}

module.exports = solve;
