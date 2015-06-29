/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(arr) {
    if (arr === undefined) {
        throw 'Error';
    } else if (!arr.length) {
        return null;
    } else {
        if (!arr.every(function(item) {
                return !isNaN(item);
            })) {
            throw 'Error';
        }
    }

    return arr.reduce(function(a, b) {
        return a*1 + b*1;
    });
}

module.exports = sum;