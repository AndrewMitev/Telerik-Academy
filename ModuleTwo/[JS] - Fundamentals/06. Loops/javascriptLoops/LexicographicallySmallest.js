/**
 * Created by Andrei on 28.5.2015 ã..
 */
var smallest = '', largest = '';

for (property in document) {
    if(property.length < smallest.length && property.length > 1) {
        smallest = property;
    }

    if(property.length > largest.length) {
        largest = property;
    }
}

console.log("Smallest document property: " + smallest + ". Largest document property: " + largest);

smallest = "lalala";
largest = "";

for (property in window) {
    if(property.length < smallest.length && property.length > 1) {
        smallest = property;
    }

    if(property.length > largest.length) {
        largest = property;
    }
}

console.log("Smallest window property: " + smallest + ". Largest window property: " + largest);

smallest = "";
largest = "";

for (property in navigator) {
    if(property.length < smallest.length && property.length > 1) {
        smallest = property;
    }

    if(property.length > largest.length) {
        largest = property;
    }
}

console.log("Smallest navigator property: " + smallest + ". Largest navigator property: " + largest);


