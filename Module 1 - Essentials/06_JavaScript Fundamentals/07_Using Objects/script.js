//Problem 1. Planar coordinates
document.getElementById('check1').onclick = firstProblem;
function firstProblem() {
    var line1 = {
            x1: document.getElementById('input1-1-x').value,
            y1: document.getElementById('input1-1-y').value,
            x2: document.getElementById('input1-2-x').value,
            y2: document.getElementById('input1-2-y').value
        },
        line2 = {
            x1: document.getElementById('input2-1-x').value,
            y1: document.getElementById('input2-1-y').value,
            x2: document.getElementById('input2-2-x').value,
            y2: document.getElementById('input2-2-y').value
        },
        line3 = {
            x1: document.getElementById('input3-1-x').value,
            y1: document.getElementById('input3-1-y').value,
            x2: document.getElementById('input3-2-x').value,
            y2: document.getElementById('input3-2-y').value
        };

    function calculateLenght(line) {
        return Math.sqrt((line.x2 - line.x1) * (line.x2 - line.x1) + (line.y2 - line.y1) * (line.y2 - line.y1))
    }

    function canCreateTriangle(line1, line2, line3) {
        return calculateLenght(line1) < calculateLenght(line2) + calculateLenght(line3) &&
            calculateLenght(line2) < calculateLenght(line1) + calculateLenght(line3) &&
            calculateLenght(line3) < calculateLenght(line1) + calculateLenght(line2)
    }

    document.getElementById('result1').innerHTML = 'Such lines can create triangle: ' + canCreateTriangle(line1, line2, line3);
}

//Problem 2. Remove elements
document.getElementById('check2').onclick = secondProblem;
function secondProblem() {
    Array.prototype.remove = function (value) {
        while (this.indexOf(value) >= 0) {
            this.splice(this.indexOf(value), 1);
        }
        return this;
    }

    var seq = document.getElementById('input2-1').value,
        arr = seq.split(', '),
        element = document.getElementById('input2-2').value;

    document.getElementById('result2').innerHTML = arr.remove(element).join(', ')
}

//common object for problems 3 and 4
var obj = {
    'first name': 'Kolyo',
    'last name': 'Nikolaev',
    age: 55,
    gender: 'male'
};

//Problem 3. Deep copy
document.getElementById('show3').onclick = show3Source;
function show3Source() {
	document.getElementById('show3').onclick = null;
    for (var prop in obj) {
        document.getElementById('source3').innerHTML += prop + ': ' + obj[prop] + '<br />'
    }

    document.getElementById('check3').onclick = thirdProblem;
    function thirdProblem() {
        function deepCopy(obj) {
            function F() {
            }

            F.prototype = obj;
            return new F();
        }

        var copy = deepCopy(obj);

        for (var prop in copy) {
            document.getElementById('result3').innerHTML += prop + ': ' + copy[prop] + '<br />'
        }
    }
}

//Problem 4. Has property
document.getElementById('show4').onclick = show4Source;
function show4Source() {
	document.getElementById('show4').onclick = null;
    for (var prop in obj) {
        document.getElementById('source4').innerHTML += prop + ': ' + obj[prop] + '<br />'
    }

    document.getElementById('check4').onclick = fourthProblem;
    function fourthProblem() {
        var prop = document.getElementById('input4').value;

        document.getElementById('result4').innerHTML = (prop in obj) ? 'property ' + prop + ' exists - value: ' + obj[prop] : 'such property doesn\'t exist in the searched object';
    }
}

//common array and print function for problems 5 and 6
var people = [
    {firstname: 'Bruce', lastname: 'Wayne', age: 33},
    {firstname: 'Peter', lastname: 'Parker', age: 23},
    {firstname: 'Max', lastname: 'Payne', age: 50},
    {firstname: 'Uncle', lastname: 'Sam', age: 99},
    {firstname: 'Clark', lastname: 'Kent', age: 234},
    {firstname: 'Captain', lastname: 'America', age: 159},
    {firstname: 'Dorian', lastname: 'Gray', age: 1732},
    {firstname: 'Mary', lastname: 'Riley', age: 30},
    {firstname: 'Captain', lastname: 'Nemo', age: 99},
    {firstname: 'Jack', lastname: 'Ryan', age: 30},
    {firstname: 'Bruce', lastname: 'Banner', age: 33},
    {firstname: 'Jean', lastname: 'Gray', age: 25},
    {firstname: 'Hank', lastname: 'McCoy', age: 23}
];
function printPeople(arr, destination, key) {
	//document.getElementById(destination).innerHTML = 'Persons: ' + '<br>';
    arr.forEach(function (item) {
        for (var prop in item) {
            if (item[prop] === item[key]) {
                continue;
            }
            document.getElementById(destination).innerHTML += (prop === 'age') ? ', ' : ' ';
            document.getElementById(destination).innerHTML += item[prop];
        }
        document.getElementById(destination).innerHTML += '<br>';
    })
}

//Problem 5. Youngest person
document.getElementById('show5').onclick = show5Source;
function show5Source() {
	document.getElementById('show5').onclick = null;
    printPeople(people, 'source5');
    document.getElementById('check5').onclick = fifthProblem;
    function fifthProblem() {
        var youngest = people[0].age,
            len = people.length,
            youngestPeople = [];

        for (var i = 1; i < len; i += 1) {
            if (people[i].age < youngest) {
                youngest = people[i].age
            }
        }
        for (i = 0; i < len; i += 1) {
            if (people[i].age === youngest) {
                youngestPeople.push(people[i])
            }
        }

        document.getElementById('result5').innerHTML = 'Age: ' + youngest + '<br>';
        printPeople(youngestPeople, 'result5', 'age');
    }
}

//Problem 6.
document.getElementById('show6').onclick = show6Source;
function show6Source() {
	document.getElementById('show6').onclick = null;
    printPeople(people, 'source6');
    document.getElementById('check6').onclick = sixthProblem;
    function sixthProblem() {
        var groupByFirstName = group(people, 'firstname'),
            groupByLastName = group(people, 'lastname'),
            groupByAge = group(people, 'age');

        function group(arr, prop) {
            var i,
                len = arr.length,
                result = {};

            if (prop === 'firstname') {
                for (i = 0; i < len; i += 1) {
                    if (result[arr[i].firstname]) {
                        result[arr[i].firstname].push(arr[i]);
                    } else {
                        result[arr[i].firstname] = [arr[i]];
                    }
                }
                return result;
            }
            if (prop === 'lastname') {
                for (i = 0; i < len; i += 1) {
                    if (result[arr[i].lastname]) {
                        result[arr[i].lastname].push(arr[i]);
                    } else {
                        result[arr[i].lastname] = [arr[i]];
                    }
                }
                return result;
            }
            if (prop === 'age') {
                for (i = 0; i < len; i += 1) {
                    if (result[arr[i].age]) {
                        result[arr[i].age].push(arr[i]);
                    } else {
                        result[arr[i].age] = [arr[i]];
                    }
                }
                return result;
            }
        }

        document.getElementById('result6').innerHTML = 'Grouped by first name:' + '<br>';
        for (var prop in groupByFirstName) {
            document.getElementById('result6').innerHTML += '<i><u>' + prop + '</u></i><br>';
            printPeople(groupByFirstName[prop], 'result6', 'firstname');
            document.getElementById('result6').innerHTML += '<hr>';
        }
        document.getElementById('result6').innerHTML += '<br>' + 'Grouped by last name:' + '<br>';
        for (var prop in groupByLastName) {
            document.getElementById('result6').innerHTML += '<i><u>' + prop + '</u></i><br>';
            printPeople(groupByLastName[prop], 'result6', 'lastname');
            document.getElementById('result6').innerHTML += '<hr>';
        }
        document.getElementById('result6').innerHTML += '<br>' + 'Grouped by age:' + '<br>';
        for (var prop in groupByAge) {
            document.getElementById('result6').innerHTML += '<i><u>' + prop + '</u></i><br>';
            printPeople(groupByAge[prop], 'result6', 'age');
            document.getElementById('result6').innerHTML += '<hr>';
        }
    }
}