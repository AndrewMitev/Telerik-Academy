/**
 * Created by Andrei on 4.6.2015 ã..
 */
function MakePoint(x, y) {
    return {
        x: x,
        y: y
    }
}

function MakeLine(pointOne, pointTwo) {
    return {
        p1: pointOne,
        p2: pointTwo
    }
}

function CalculateDistanceBetweenPoints(pointOne, pointTwo) {
    return Math.round(Math.sqrt( Math.pow( (pointOne.x - pointOne.y), 2) + Math.pow( (pointTwo.x - pointTwo.y),2) ));
}

function CheckIfLinesFormTriangle(lineOne, lineTwo, lineThree) {
    var lenghtOne,
        lenghtTwo,
        lenghtThree;

    lenghtOne = CalculateDistanceBetweenPoints(lineOne.p1, lineOne.p2);
    lenghtTwo = CalculateDistanceBetweenPoints(lineTwo.p1, lineTwo.p2);
    lenghtThree = CalculateDistanceBetweenPoints(lineThree.p1, lineThree.p2);

    if(lenghtOne + lenghtTwo < lenghtThree || lenghtOne + lenghtThree  < lenghtTwo || lenghtTwo + lenghtThree < lenghtOne) {
        return false;
    }

    return true;
}

var pointOne,
    pointTwo,
    pointThree,
    pointFour,
    pointFive,
    pointSix,
    sideOne,
    sideTwo,
    sideThree;

pointOne = MakePoint(2, 4);
pointTwo = MakePoint(-2, 0.23);
pointThree = MakePoint(4, 9);
pointFour = MakePoint(1, 2);
pointFive = MakePoint(-3, 8);
pointSix = MakePoint(4, 10);

console.log("Distance between Point One and Point Two is " +  CalculateDistanceBetweenPoints(pointOne, pointTwo));

sideOne = MakeLine(pointOne, pointTwo);
sideTwo = MakeLine(pointThree, pointFour);
sideThree = MakeLine(pointFive, pointSix);

console.log("Can set sides create triangle? " + CheckIfLinesFormTriangle(sideOne, sideTwo, sideThree));

