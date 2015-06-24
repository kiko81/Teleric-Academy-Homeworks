//Problem 1. Increase array members
document.getElementById('check1').onclick = firstProblem;
function firstProblem() {
    var arr = new Array(20),
        i,
        len = arr.length;
    for (i = 0; i < len; i += 1) {
        arr[i] = i * 5;
    }
    document.getElementById('result1').innerHTML = arr.join(', ');
    console.log(arr.join(', '));
}

//Problem 2. Lexicographically comparison
document.getElementById('check2').onclick = secondProblem;
function secondProblem() {
    var first = document.getElementById('input2-1').value,
        second = document.getElementById('input2-2').value,
        i,
        result = 'equal',
        len = Math.min(first.length, second.length);


    for (i = 0; i < len; i += 1) {
        if (first[i] > second[i]) {
            result = 'first text is first lexicographically';
            break;
        } else if (first[i] < second[i]) {
            result = 'second text is first lexicographically';
            break;
        }
    }
    if (result === 'equal') {
        if (first.length > second.length) {
            result = 'second text is first lexicographically';
        } else if (first.length < second.length) {
            result = 'first text is first lexicographically';
        } else {
            result = 'texts are equal';
        }
    }
    document.getElementById('result2').innerHTML = result;
}

//Problem 3. Maximal sequence
document.getElementById('check3').onclick = thirdProblem;
function thirdProblem() {
    var seq = document.getElementById('input3').value,
        arr = seq.split(', '),
        element = '',
        bestElement = '',
        sequence = 1,
        bestSequence = 1,
        len = arr.length;
    document.getElementById('result3').innerHTML = '';
    for (var i = 1; i < len; i += 1) {
        if (arr[i - 1] == arr[i]) {
            sequence++;
            element = arr[i];
        } else {
            sequence = 1;
        }
        if (sequence > bestSequence) {
            bestSequence = sequence;
            bestElement = element;
        }
    }
    for (var j = 0; j < bestSequence; j += 1) {
        if (j != bestSequence - 1) {
            document.getElementById('result3').innerHTML += bestElement + ', ';
        } else {
            document.getElementById('result3').innerHTML += bestElement;
        }
    }
}

//Problem 4. Maximal increasing sequence
document.getElementById('check4').onclick = fourthProblem;
function fourthProblem() {
    var seq = document.getElementById('input4').value,
        arr = seq.split(', ').map(Number),
        max = 1,
        currentMax = 1,
        index = 0,
        len = arr.length;
    for (i = 1; i < len; i += 1) {
        if (arr[i] > arr[i - 1]) {
            currentMax += 1;
            if (currentMax > max) {
                max = currentMax;
                index = i;
            }
        } else {
            currentMax = 1;
        }
    }
    document.getElementById('result4').innerHTML = arr.splice(index - max + 1, max).join(', ');
}

//Problem 5. Selection sort
document.getElementById('check5').onclick = fifthProblem;
function fifthProblem() {
    var seq = document.getElementById('input5').value,
        arr = seq.split(', ').map(Number),
        len = arr.length,
        minIndex,
        result = [];
    for (var i = 0; i < len; i += 1) {
        minIndex = i;
        for (var j = i + 1; j < len; j += 1) {
            if (arr[j] < arr[minIndex]) {
                minIndex = j;
            }
        }
                //Using hinted 2nd array
        result.push(arr[minIndex]);
        arr[minIndex] = arr[i];

                //without 2nd array
        //if (minIndex !== i) {
        //    var tmp = arr[i];
        //    arr[i] = arr[minIndex];
        //    arr[minIndex] = tmp;
        //}
        //result = arr; //in order to print correctly
    }
    document.getElementById('result5').innerHTML = result.join(', ');
}

//Problem 6. Most frequent number
document.getElementById('check6').onclick = sixthProblem;
function sixthProblem() {
    var seq = document.getElementById('input6').value,
        arr = seq.split(', ').map(Number),
        counter = 1,
        bestFreq = 1,
        freqNumber = arr[0],
        len = arr.length;
    arr.sort(function(a, b) {
        return a - b;
    });
    for (var i = 1; i < len; i += 1) {
        if (arr[i - 1] === arr[i]) {
            counter++;
        } else {
            counter = 1;
        }
        if (counter > bestFreq) {
            bestFreq = counter;
            freqNumber = arr[i];
        }
    }
    document.getElementById('result6').innerHTML = freqNumber + ' (' + bestFreq + ' times)';
}

//Problem 7. Binary search
document.getElementById('check7').onclick = sevethhproblem;
function sevethhproblem() {
    var seq = document.getElementById('input7-1').value,
        key = document.getElementById('input7-2').value * 1 | 0,
        arr = seq.split(', ').map(Number),
        first = 0,
        last = arr.length - 1,
        index,
        keyFound = false;
    arr.sort(function(a, b) {
        return a - b;
    });
    while (last >= first && !keyFound) {
        index = (first + last) / 2 | 0;
        if (arr[index] > key) {
            last = index - 1;
        } else if (arr[index] < key) {
            first = index + 1;
        } else {
            keyFound = true;
        }
    }
    if (keyFound) {
        document.getElementById('result7').innerHTML = key + ' is on #' + index + ' index in the sorted array(ascending)'
    } else {
        document.getElementById('result7').innerHTML = 'not found'
    }
}