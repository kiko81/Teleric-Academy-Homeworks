//Problem 1. Odd or Even
document.getElementById('check1').onclick = firstProblem;
function firstProblem() {
    document.getElementById('result1').innerHTML = document.getElementById('input1').value % 2 !== 0
}

//Problem 2. Divisible by 7 and 5
document.getElementById('check2').onclick = secondProblem;
function secondProblem() {
    var input = document.getElementById('input2').value;
    document.getElementById('result2').innerHTML = input % 3 === 0 && input % 7 === 0
}

//Problem 3. Rectangle area
document.getElementById('check3').onclick = thirdProblem;
function thirdProblem() {
    var width = parseFloat(document.getElementById('input3-width').value),
        height = parseFloat(document.getElementById('input3-height').value);
    document.getElementById('result3').innerHTML = width*height
}

//Problem 4. Third digit 7
document.getElementById('check4').onclick = fourthProblem;
function fourthProblem() {
    var input = document.getElementById('input4').value,
        len = input.length;
    document.getElementById('result4').innerHTML = input[len - 3] === '7'
}

//Problem 5. Third bit
document.getElementById('check5').onclick = fifthProblem;
function fifthProblem() {
    var input = document.getElementById('input5').value;
    document.getElementById('result5').innerHTML = (input >> 3) & 1
}

//Problem 6. Point in Circle
document.getElementById('check6').onclick = sixthProblem;
function sixthProblem() {
    var x = parseFloat(document.getElementById('input6-x').value),
        y = parseFloat(document.getElementById('input6-y').value);
    document.getElementById('result6').innerHTML = Math.sqrt(Math.pow(x, 2)+Math.pow(y, 2)) <= 5
}

//Problem 7. Is prime
document.getElementById('check7').onclick = seventhProblem;
function seventhProblem() {
    var input = document.getElementById('input7').value,
        isPrime = true;
    if (input == 1) {
        isPrime = false;
    } else if (isPrime == 2){
        isPrime = true;
    } else {
        for (var i = 2; i <= Math.sqrt(input); i += 1) {
            if (input % i == 0) {
                isPrime = false;
                break;
            }
        }
    }
    document.getElementById('result7').innerHTML = isPrime
}

//Problem 8. Trapezoid area
document.getElementById('check8').onclick = eighthProblem;
function eighthProblem() {
    var a = parseFloat(document.getElementById('input8-a').value),
        b = parseFloat(document.getElementById('input8-b').value),
        height = parseFloat(document.getElementById('input8-height').value);
    document.getElementById('result8').innerHTML = (a+b)*height/2
}

//Problem 9. Point in Circle and outside Rectangle
document.getElementById('check9').onclick = ninthProblem;
function ninthProblem() {
    var x = parseFloat(document.getElementById('input9-x').value),
        y = parseFloat(document.getElementById('input9-y').value),
        inCircle = Math.sqrt(Math.pow(x-1, 2)+Math.pow(y-1, 2)) <= 3,
        inRectangle = x >= -1 && x <= 5 && y <= 1 && y >= -1;
    document.getElementById('result9').innerHTML = inCircle && !inRectangle ? 'yes' : 'no'
}
