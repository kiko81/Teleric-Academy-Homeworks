var count = 0,

	literals = {
		integerLiteral: 42,
		floatLiteral: 3.14e-15,
		arrayLiteral: [123, "Pesho", false],
		booleanLiteral: true,
		objectLiteral: {
			age: 12,
			name: 'Gosho'
		},
		stringLiteral: '"Hello, JavaScript"',
		functionLiteral: function (){},
		nullLiteral: null,
		undefinedLiteral: undefined,
	},

	quotedText = '`\'How you doin\'?\', Joey said\'.',

	firstDiv = document.getElementById('literals'),
	secondDiv = document.getElementById('quoted-text'),
	thirdDiv = document.getElementById('types'),
	fourthDiv = document.getElementById('null-types');

//Problem 1. JavaScript literals
for (var property in literals) {
	firstDiv.innerHTML += property + ' = ' + literals[property] + ' <br />';
}

//Problem 2. Quoted text
secondDiv.innerHTML += 'Text with quotes: ' + quotedText;

for (var property in literals) {
	count += 1;
	if (count < 8) /*Problem 3. Typeof variables*/ {
		thirdDiv.innerHTML += 'typeof(' + property + ') = ' + typeof(literals[property]) + ' <br />';
	} else /*Problem 4. Typeof null*/ {
		fourthDiv.innerHTML += 'typeof(' + property + ') = ' + typeof(literals[property]) + ' <br />';
	}
}