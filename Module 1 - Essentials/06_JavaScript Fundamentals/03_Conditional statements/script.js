//Problem 1. Exchange if greater
document.getElementById('check1').onclick = firstProblem;
function firstProblem() {
    var a = document.getElementById('input1-a').value * 1,
        b = document.getElementById('input1-b').value * 1;
    if (a > b) {
        var tmp;
        tmp = a;
        a = b;
        b = tmp;
    }
    document.getElementById('result1').innerHTML = a + ' ' + b;
}

//Problem 2. Multiplication Sign
document.getElementById('check2').onclick = secondProblem;
function secondProblem() {
    var a = document.getElementById('input2-a').value * 1,
        b = document.getElementById('input2-b').value * 1,
        c = document.getElementById('input2-c').value * 1,
        minus = 0,
        sign;
    if (a == 0 || b == 0 || c == 0) {
        sign = '0';
    } else {
        if (a < 0) {
            minus++;
        }
        if (b < 0) {
            minus++;
        }
        if (c < 0) {
            minus++;
        }
        if (minus % 2 == 0) {
            sign = '+';
        }
        else {
            sign = '-';
        }
    }
    document.getElementById('result2').innerHTML = sign;
}

//Problem 3. The biggest of Three
document.getElementById('check3').onclick = thirdProblem;
function thirdProblem() {
    var a = document.getElementById('input3-a').value * 1,
        b = document.getElementById('input3-b').value * 1,
        c = document.getElementById('input3-c').value * 1,
        biggest;
    if (a >= b && a >= c) {
        biggest = a;
    } else if (b >= c) {
        biggest = b;
    } else {
        biggest = c;
    }
    document.getElementById('result3').innerHTML = biggest;
}

//Problem 4. Sort 3 numbers
document.getElementById('check4').onclick = fourthProblem;
function fourthProblem() {
    var a = document.getElementById('input4-a').value * 1,
        b = document.getElementById('input4-b').value * 1,
        c = document.getElementById('input4-c').value * 1,
        biggest,
        bigger,
        smallest;
    if (a >= b && a >= c) {
        biggest = a;
        if (b >= c) {
            bigger = b;
            smallest = c;
        } else {
            bigger = c;
            smallest = b;
        }
    } else if (b >= c) {
        biggest = b;
        if (a >= c) {
            bigger = a;
            smallest = c;
        } else {
            bigger = c;
            smallest = a;
        }
    } else {
        biggest = c;
        if (a >= b) {
            bigger = a;
            smallest = b;
        } else {
            bigger = b;
            smallest = a;
        }
    }
    document.getElementById('result4').innerHTML = biggest + ' ' + bigger + ' ' + smallest;
}

//Problem 5. Digit as word
document.getElementById('check5').onclick = fifthProblem;
function fifthProblem() {
    var number = document.getElementById('input5').value;
    switch (number) {
        case '1':
            number = 'one';
            break;
        case '2':
            number = 'two';
            break;
        case '3':
            number = 'three';
            break;
        case '4':
            number = 'four';
            break;
        case '5':
            number = 'five';
            break;
        case '6':
            number = 'six';
            break;
        case '7':
            number = 'seven';
            break;
        case '8':
            number = 'eight';
            break;
        case '9':
            number = 'nine';
            break;
        default:
            number = 'not a digit';
            break;
    }
    document.getElementById('result5').innerHTML = number;
}

//Problem 6. Quadratic equation
document.getElementById('check6').onclick = sixthProblem;
function sixthProblem() {
    var a = document.getElementById('input6-a').value * 1,
        b = document.getElementById('input6-b').value * 1,
        c = document.getElementById('input6-c').value * 1,
        d = b * b - 4 * a * c;
    if (d < 0) {
        document.getElementById('result6').innerHTML = 'no real roots';
    } else if (d == 0) {
        document.getElementById('result6').innerHTML = 'x1=x2=' + -b / (2 * a);
    } else {
        document.getElementById('result6').innerHTML = 'x1=' + (-b - Math.sqrt(d)) / (2 * a) + '; x2=' + (-b + Math.sqrt(d)) / (2 * a);
    }
}

//Problem 9. The biggest of five numbers
document.getElementById('check7').onclick = seventhProblem;
function seventhProblem() {
    var a = document.getElementById('input7-a').value * 1,
        b = document.getElementById('input7-b').value * 1,
        c = document.getElementById('input7-c').value * 1,
        d = document.getElementById('input7-c').value * 1,
        e = document.getElementById('input7-c').value * 1,
        biggest;
    if (a >= b && a >= c && a >= d && a >= e) {
        biggest = a;
    } else if (b >= c && b >= d && b >= e) {
        biggest = b;
    } else if (c >= d && c >= e) {
        biggest = c;
    } else if (d >= e) {
        biggest = d;
    } else {
        biggest = e;
    }
    document.getElementById('result7').innerHTML = biggest;
}

//Problem 8. Number as words
document.getElementById('check8').onclick = eighthProblem;
function eighthProblem() {
    var number = document.getElementById('input8').value;
    if (number.length === 1) {
        number = '00' + number;
    }
    if (number.length === 2) {
        number = '0' + number;
    }
    var a = number[0] * 1,
        b = number[1] * 1,
        c = number[2] * 1,
        stringNum;
    switch (a) {
        case 1:
            a = 'one hundred';
            break;
        case 2:
            a = 'two hundred';
            break;
        case 3:
            a = 'three hundred';
            break;
        case 4:
            a = 'four hundred';
            break;
        case 5:
            a = 'five hundred';
            break;
        case 6:
            a = 'six hundred';
            break;
        case 7:
            a = 'seven hundred';
            break;
        case 8:
            a = 'eight hundred';
            break;
        case 9:
            a = 'nine hundred';
            break;
        default:
            a = '';
            break;
    }
    if (b === 1) {
        switch (c) {
            case 1:
                b = 'eleven';
                break;
            case 2:
                b = 'twelve';
                break;
            case 3:
                b = 'thirteen';
                break;
            case 4:
                b = 'fourteen';
                break;
            case 5:
                b = 'fifteen';
                break;
            case 6:
                b = 'sixteen';
                break;
            case 7:
                b = 'seventeen';
                break;
            case 8:
                b = 'eighteen';
                break;
            case 9:
                b = 'nineteen';
                break;
            default:
                b = 'ten';
                break;
        }
        c = '';
    } else {
        switch (b) {
            case 2:
                b = 'twenty ';
                break;
            case 3:
                b = 'thirty ';
                break;
            case 4:
                b = 'forty ';
                break;
            case 5:
                b = 'fifty ';
                break;
            case 6:
                b = 'sixty ';
                break;
            case 7:
                b = 'seventy ';
                break;
            case 8:
                b = 'eighty ';
                break;
            case 9:
                b = 'ninety ';
                break;
            default:
                b = '';
                break;
        }
        switch (c) {
            case 1:
                c = 'one';
                break;
            case 2:
                c = 'two';
                break;
            case 3:
                c = 'three';
                break;
            case 4:
                c = 'four';
                break;
            case 5:
                c = 'five';
                break;
            case 6:
                c = 'six';
                break;
            case 7:
                c = 'seven';
                break;
            case 8:
                c = 'eight';
                break;
            case 9:
                c = 'nine';
                break;
            default:
                c = '';
                break;
        }
    }
    if (b == 0 && c == 0) {
        if (a == 0) {
            stringNum = 'zero';
        } else {
            stringNum = a;
        }
    } else if (a == 0) {
        stringNum = b + c;
    } else {
        stringNum = a + ' and ' + b + c;
    }
    document.getElementById('result8').innerHTML = stringNum[0].toUpperCase() + stringNum.substring(1);
}

