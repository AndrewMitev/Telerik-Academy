/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(array) {
  if (array === undefined) {
	  throw new Error('You need to pass parameter!');
  }

  if (array.length === 0) {
	  return null;
  }

  if (array.some(function (number) {
		  return !+number;
	  })) {
	  throw new Error('Function needs array of numbers!');
  }

  return array.reduce(function (sum, item) {
	  return sum += +item;
  }, 0);
}

module.exports = sum;