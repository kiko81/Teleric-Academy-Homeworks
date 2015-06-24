//Problem 1. Reverse string
document.getElementById('check1').onclick = firstProblem;
function firstProblem() {
    var string = document.getElementById('input1').value,
        len = string.length,
        result = '';
    for (var i = len - 1; i >= 0; i--) {
        result += string[i]
    }
    document.getElementById('result1').innerHTML = result;
}

//Problem 2. Correct brackets
document.getElementById('check2').onclick = secondProblem;
function secondProblem() {
    var expr = document.getElementById('input2').value;

    function checkBrackets(text) {
        var brackets = 0,
            len = text.length;
        for (var char = 0; char < len; char += 1) {
            if (text[char] === '(') {
                brackets++;
            }
            if (text[char] === ')') {
                brackets--;
            }
            console.log(brackets);
            if (brackets < 0) {
                return false;
            }
        }
        return brackets === 0;
    }

    document.getElementById('result2').innerHTML = 'Expression is correct: ' + checkBrackets(expr);
}

//Problem 3. Sub-string in text
document.getElementById('check3').onclick = thirdProblem;
function thirdProblem() {
    var text = document.getElementById('input3-1').value,
        word = document.getElementById('input3-2').value,
        re = new RegExp(word, 'gi');

    document.getElementById('result3').innerHTML = text.match(re).length + ' times';
}

//Problem 4. Parse tags
document.getElementById('check4').onclick = fourthProblem;
function fourthProblem() {
    var text = document.getElementById('input4').value,
        result = '',
        lowTag = '<lowcase>',
        lowClose = '</lowcase>',
        upTag = '<upcase>',
        upClose = '</upcase>',
        mixTag = '<mixcase>',
        mixClose = '</mixcase>',
        flag = true;

    while (flag) {
        for (var i = 0; i < text.length; i += 1) {
            if (text.substr(i, lowTag.length).toLowerCase() === '<lowcase>') {
                text = text.replace(lowTag, '');
                while (i < text.length - lowClose.length && text.substr(i, lowClose.length) !== lowClose) {
                    result += '' + text[i].toLowerCase();
                    i += 1;
                }
                text = text.replace(lowClose, '');
            }
            if (text.substr(i, upTag.length).toLowerCase() === '<upcase>') {
                text = text.replace(upTag, '');
                while (i < text.length - upClose.length && text.substr(i, upClose.length) !== upClose) {
                    result += '' + text[i].toUpperCase();
                    i += 1;
                }
                text = text.replace(upClose, '');
            }
            if (text.substr(i, mixTag.length).toLowerCase() === '<mixcase>') {
                text = text.replace(mixTag, '');
                while (i < text.length - mixClose.length && text.substr(i, mixClose.length) !== mixClose) {
                    if (Math.random() >= 0.5) {
                        result += '' + text[i].toUpperCase();
                    }
                    else {
                        result += '' + text[i].toLowerCase();
                    }
                    i += 1;
                }
                text = text.replace(mixClose, '');
            }
            result += text[i];
        }
        flag = !(result.length === text.length)
    }
    document.getElementById('result4').innerHTML = result;
}

//Problem 5. nbsp
function replaceWhiteSpace(text) {
    return text.replace(/\s/g, '&nbsp;')
}
document.getElementById('result5').innerHTML = replaceWhiteSpace('some text with spaces')
console.log('5th problem output: ' + replaceWhiteSpace('some text with spaces'))

//Problem 6. Extract text from HTML
document.getElementById('check6').onclick = sixthProblem;
function sixthProblem() {
    var html = document.getElementById('input6').value,
        result = html.replace(/<[^>]*>/g, "");
    document.getElementById('result6').innerHTML = result;
}

//Problem 7. Parse URL
document.getElementById('check7').onclick = seventhProblem;
function seventhProblem() {
    document.getElementById('check7').onclick = null;
    var url = document.getElementById('input7').value,
        objectURL = {
            protocol: url.match(/(.*):\/\//)[1],
            server: url.match(/:\/\/(.*?)\//)[1],
            resource: url.match(/[A-z](\/.*)/)[1]
        }

    for (var prop in objectURL) {
        document.getElementById('result7').innerHTML += prop + ': ' + objectURL[prop] + '<br>'
    }
}

//Problem 8. Replace tags
document.getElementById('check8').onclick = eighthProblem;
function eighthProblem() {
    var html = document.getElementById('input8').value;
    html = html.replace(/<a href=/g, '[URL=');
    html = html.replace(/">/g, '"]');
    html = html.replace(/<\/a>/g, '[/URL]');

    document.getElementById('result8').innerHTML = html
}

//Problem 9. Extract e-mails
document.getElementById('check9').onclick = ninthProblem;
function ninthProblem() {
    document.getElementById('check9').onclick = null;
    var text = document.getElementById('input9').value,
        result = text.match(/([a-z0-9._-]+@[a-z0-9._-]+\.[a-z0-9._-]+)/gi)

    for (var prop in result) {
        document.getElementById('result9').innerHTML += result[prop] + '<br>'
    }
}

//Problem 10. Find palindromes
document.getElementById('check10').onclick = tenthProblem;
function tenthProblem() {
    document.getElementById('check10').onclick = null;
    var text = document.getElementById('input10').value.split(' ');

    text.forEach(function (item) {
        for (var i = 0; i < Math.ceil(item.length / 2); i += 1) {
            if (item[i] !== item[item.length - i - 1]) {
                break;
            }
            if (i === Math.ceil(item.length / 2) - 1) {
                document.getElementById('result10').innerHTML += item + '<br>'
            }
        }
    })
}

//Problem 11. String format
function stringFormat(text, holders) {
    for (var i = holders.length - 1; i >= 0; i -= 1) {
        while (text.indexOf('{' + i + '}') !== -1) {
            text = text.replace('{' + i + '}', holders[i]);
        }
    }
    return text;
}

var placeHolder = [1, 'Pesho', 'Gosho'],
    frmt = '{0}, {1}, {0} text {2}';
console.log('Problem 11\n' + 'text to fill: ' + frmt + '\nitems to append: ' + placeHolder.join(', ') + '\nresult: ' + stringFormat(frmt, placeHolder))

//Problem 12. Generate list
function generateList(arr, template) {
    var element = ['name', 'age'],
        result = '';

    function generateLi(person) {
        var liContent = template;
        for (var i in element) {
            while (liContent.indexOf('<strong>-{' + element[i] + '}-') !== -1) {
                liContent = liContent.replace(('-{' + element[i] + '}-'), person.name);
            }
            while (liContent.indexOf('<span>-{' + element[i] + '}-') !== -1) {
                liContent = liContent.replace(('-{' + element[i] + '}-'), person.age);
            }
        }
        liContent = '<li>' + liContent + '</li>';
        return liContent;
    }

    result = '<ul>' +'\n';
    for (var prop in arr) {
        result += generateLi(arr[prop]) + '\n';
    }
    result += '</ul>';
    return result;
}

var people = [{name: 'Peter', age: 14},{name: 'Pesho', age: 7},{name: 'Gosho', age: 33}];
var template = '<strong>-{name}-</strong> <span>-{age}-</span>';
console.log('Problem 12:\n'+ generateList(people, template))
