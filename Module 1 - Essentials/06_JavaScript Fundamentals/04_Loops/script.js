//Problem 1. Numbers
document.getElementById('check1').onclick = firstProblem;
function firstProblem() {
    document.getElementById('result1').innerHTML = '';
    var a = document.getElementById('input1').value;
    for (var i = 1; i <= a; i += 1) {
        document.getElementById('result1').innerHTML += i + ' ';
    }
}

//Problem 2. Numbers not divisible
document.getElementById('check2').onclick = secondProblem;
function secondProblem() {
    document.getElementById('result2').innerHTML = '';
    var a = document.getElementById('input2').value;
    for (var i = 1; i <= a; i += 1) {
        if (!(!(i % 3) && !(i % 7))) {
            document.getElementById('result2').innerHTML += i + ' '
        }
    }
}

//Problem 3. Min/Max of sequence
document.getElementById('check3').onclick = thirdProblem;
function thirdProblem() {
    var seq = document.getElementById('input3').value,
        arr = seq.split(' '),
        min = arr[0],
        max = arr[0],
        len = arr.length;
    for (var i = 1; i < len; i += 1) {
        if (arr[i] < min) {
            min = arr[i];
        }
        if (arr[i] > max) {
            max = arr[i]
        }
    }
    document.getElementById('result3-min').innerHTML = min;
    document.getElementById('result3-max').innerHTML = max;
}

//Problem 4. Lexicographically smallest
document.getElementById('check4').onclick = fourthProblem;
function fourthProblem() {
    var smallest = 'zzzzzzzzzzzzz',
        largest = '',
        prop;
    for (prop in document) {
        if (prop < smallest) {
            smallest = prop;
        }
        if ((prop > largest)) {
            largest = prop;
        }
    }
    document.getElementById('result4-1-max').innerHTML = largest;
    document.getElementById('result4-1-min').innerHTML = smallest;
    smallest = 'zzzzzzzzzzzzz';
    largest = '';
    for (prop in window) {
        if (prop < smallest) {
            smallest = prop;
        }
        if ((prop > largest)) {
            largest = prop;
        }
    }
    document.getElementById('result4-2-max').innerHTML = largest;
    document.getElementById('result4-2-min').innerHTML = smallest;
    smallest = 'zzzzzzzzzzzzz';
    largest = '';
    for (prop in navigator) {
        if (prop < smallest) {
            smallest = prop;
        }
        if ((prop > largest)) {
            largest = prop;
        }
    }
    document.getElementById('result4-3-max').innerHTML = largest;
    document.getElementById('result4-3-min').innerHTML = smallest;
}