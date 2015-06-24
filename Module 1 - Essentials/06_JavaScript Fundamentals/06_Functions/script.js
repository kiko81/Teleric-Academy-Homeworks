//Problem 1. English digit
document.getElementById('check1').onclick = firstProblem;
function firstProblem() {
    var a = document.getElementById('input1').value | 0;

    function lastDigitWord(digit) {
        words = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
        return words[digit % 10];
    }

    document.getElementById('result1').innerHTML = lastDigitWord(a);
}

//Problem 2. Reverse number
document.getElementById('check2').onclick = secondProblem;
function secondProblem() {
    var a = document.getElementById('input2').value;

    function reverseNumber(number) {
        return number.split('').reverse().join('');
    }

    document.getElementById('result2').innerHTML = reverseNumber(a);
}

//Problem 3. Occurrences of word
document.getElementById('check3').onclick = thirdProblem;
function thirdProblem() {
    var text = document.getElementById('input3-1').value,
        word = document.getElementById('input3-2').value;

    function findWord(text, word) {
        var re = new RegExp('\\b' + word + '\\b', 'gi')
        return text.match(re).length;
    }

    document.getElementById('result3').innerHTML = 'Word "' + word + '" found ' + findWord(text, word) + ' times - case insensitive';
}

//Problem 4. Number of elements
document.getElementById('check4').onclick = fourthProblem;
function fourthProblem() {
    var divs = document.getElementsByTagName('div');
    document.getElementById('result4').innerHTML = 'Number of div tags: ' + divs.length + ' - each task in div tag :)';
}

//Problem 5. Appearance count
document.getElementById('check5').onclick = fifthProblem;
function fifthProblem() {
    var seq = document.getElementById('input5-1').value,
        arr = seq.split(', ').map(Number),
        number = document.getElementById('input5-2').value | 0,
        len = arr.length;

    function count(arr, number) {
        var count = 0;
        for (var i = 0; i < len; i += 1) {
            if (arr[i] === number) {
                count += 1;
            }
        }
        return count;
    }

    function test(arr, number, expected) {
        return count(arr, number) === expected;
    }

    document.getElementById('result5').innerHTML = number + ' appears ' + count(arr, number) + ' times'
}

// used in problems 6 and 7
function BiggerThanNeighbours(arr, index) {
    return (arr[index] > arr[index - 1]) && (arr[index] > arr[index + 1]);
}
//Problem 6. Larger than neighbours
document.getElementById('check6').onclick = sixthProblem;
function sixthProblem() {
    var seq = document.getElementById('input6-1').value,
        arr = seq.split(', ').map(Number),
        index = document.getElementById('input6-2').value | 0,
        len = arr.length;

    document.getElementById('result6').innerHTML = 'Number at index #' + index + ' is bigger than its neighbours - ' + BiggerThanNeighbours(arr, index);
}

//Problem 7. First larger than neighbours
document.getElementById('check7').onclick = seventhProblem;
function seventhProblem() {
    var seq = document.getElementById('input7').value,
        arr = seq.split(', ').map(Number),
        len = arr.length;

    function firstBiggerThanNeighbours(arr) {
        for (var i = 1; i < len - 1; i+=1) {
            if (BiggerThanNeighbours(arr, i)) {
                return i;
            }
        }
        return -1;
    }

    document.getElementById('result7').innerHTML = (firstBiggerThanNeighbours(arr) > 0?'#':'') + firstBiggerThanNeighbours(arr);
}