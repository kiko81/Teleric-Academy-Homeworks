//Common arrays and functions
//<editor-fold desc="Common arrays and functions">

var firstName = ['Bruce', 'Peter', 'Max', 'Uncle', 'Clark', 'Captain', 'Dorian', 'Mary', 'Captain', 'Jack', 'Bruce', 'Jean', 'Hank'],
    lastName = ['Wayne', 'Parker', 'Payne', 'Sam', 'Kent', 'America', 'Gray', 'Riley', 'Nemo', 'Ryan', 'Banner', 'Gray', 'McCoy'];

function createPerson(fname, lname, age, gender) {
    return {
        firstname: fname,
        lastname: lname,
        age: age,
        gender: gender
    };
}

function createPeople() {
    var people = [],
        len = firstName.length;
    for (i = 0; i < 10; i += 1) {
        people[i] = createPerson(firstName[Math.random() * len | 0], lastName[Math.random() * len | 0], (Math.random() * 55) | 0, (Math.random() + .5) | 0 ? 'Female' : 'Male');
    }
    return people;
}

function printPeople(arr, destination, key) {
    arr.forEach(function (item) {
        for (var prop in item) {
            if (item[prop] === item[key]) {
                continue;
            }
            document.getElementById(destination).innerHTML += (prop === 'age' || prop === 'gender') ? ', ' : ' ';
            document.getElementById(destination).innerHTML += item[prop];
        }
        document.getElementById(destination).innerHTML += '<br>';
    })
}
//</editor-fold>
//End of Common arrays and functions

//Problem 1. Make person
document.getElementById('check1').onclick = firstProblem;
function firstProblem() {
    document.getElementById('check1').onclick = null;
    printPeople(createPeople(), 'result1');
}

//Problem 2. People of age
document.getElementById('show2').onclick = show2Source;
function show2Source() {
    document.getElementById('show2').onclick = null;
    var people = createPeople();
    printPeople(createPeople(), 'source2');

    document.getElementById('check2').onclick = secondProblem;
    function secondProblem() {
        var result = people.every(function (item) {
            return item.age >= 18
        });
        document.getElementById('result2').innerHTML = 'All people at least 18 years: ' + result;
    }
}

//Problem 3. Underage people
document.getElementById('show3').onclick = show3Source;
function show3Source() {
    document.getElementById('show3').onclick = null;
    var people = createPeople();
    printPeople(people, 'source3');
    document.getElementById('check3').onclick = thirdProblem;
    function thirdProblem() {
        var targetAge = document.getElementById('input3').value;
        people = people.filter(function (item) {
            return item.age < targetAge;
        });
        printPeople(people, 'result3');
    }
}

//Problem 4. Average age of females
document.getElementById('show4').onclick = show4Source;
function show4Source() {
    document.getElementById('show4').onclick = null;
    var people = createPeople();
    printPeople(people, 'source4');

    document.getElementById('check4').onclick = fourthProblem;
    function fourthProblem() {
        var result = 0;
        people = people.filter(function (item) {
            return item.gender === 'Female';
        });
        people.forEach(function (item) {
            return result += item.age;
        })
        document.getElementById('result4').innerHTML = 'Average age of females: ' + (result / people.length).toFixed(2) + '<br>' + 'Females: ' + '<br>';
        printPeople(people, 'result4', 'gender');
    }
}

//Problem 5. Youngest person
document.getElementById('show5').onclick = show5Source;
function show5Source() {
    document.getElementById('show5').onclick = null;
    var people = createPeople();
    printPeople(people, 'source5');
    document.getElementById('check5').onclick = fifthProblem;
    function fifthProblem() {

        if (!Array.prototype.find) {
            Array.prototype.find = function (callback) {
                var i, len = this.length;
                for (i = 0; i < len; i += 1) {
                    if (callback(this[i], i, this)) {
                        return this[i];
                    }
                }
            };
        }

        var youngestMale = people.sort(function (a, b) {
            return a.age - b.age;
        }).find(function (item) {
            return item.gender === 'Male';
        });

        document.getElementById('result5').innerHTML = youngestMale.age + '<br>' + youngestMale.firstname + ' ' + youngestMale.lastname;
    }
}

//Problem 6.
document.getElementById('show6').onclick = show6Source;
function show6Source() {
    document.getElementById('show6').onclick = null;
    var people = createPeople();
    printPeople(people, 'source6');
    document.getElementById('check6').onclick = sixthProblem;
    function sixthProblem() {
        var result = people.reduce(function(obj, item) {
            if (obj[item.firstname[0]]) {
                obj[item.firstname[0]].push(item);
            } else {
                obj[item.firstname[0]] = [item];
            }
            return obj;
        }, {});

        for (var prop in result) {
            document.getElementById('result6').innerHTML += prop +': ' + '<br>';
            printPeople(result[prop], 'result6');
            document.getElementById('result6').innerHTML += '<hr>'

        }

    }
}