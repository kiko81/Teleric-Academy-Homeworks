//Problem 1. Format with placeholders
//
//    Write a function that formats a string. The function should have placeholders
//      Add the function to the String.prototype
var template = 'My name is #{name} and I am #{age}-years-old.',
    person = {name: 'John', age: 13};

String.prototype.format = function (options) {
    var result = this;
    for (var prop in options) {
        result = result.replace(new RegExp('#{' + prop + '}', 'g'), options[prop])
    }
    return result
}

console.log('Problem 1: ' + template.format(person));

//Problem 2. HTML binding
//
//Write a function that puts the value of an object into the content/attributes of HTML tags.
//    Add the function to the String.prototype

var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></à>',
    options = {name: 'Elena', link: 'http://telerikacademy.com'};

String.prototype.bind = function (input, options) {
    for (var prop in options) {
        var reContent = new RegExp('(<.*data-bind-content="' + prop + '".*>)(.*)(</*>)', 'gi'),
            reHref = new RegExp('(<.*data-bind-href="' + prop + '")', 'gi'),
            reClass = new RegExp('(data-bind-class="' + prop + '")', 'gi');
        
        input = input.replace(reContent, function (_, opening, content, closing) {
            console.log(closing)
            content = options[prop];
            return opening + content + closing;
        }).replace(reHref, function (_, content) {
            return content + ' href="' + options[prop] + '"';
        }).replace(reClass, 'data-bind-class="' + options[prop] + '"');
    }
    return input;
}

console.log('Problem 2: ' + bindingString.bind(bindingString, options))