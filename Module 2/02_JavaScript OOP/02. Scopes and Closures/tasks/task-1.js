/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */

function solve() {
    var library = (function () {
        var books = [];
        var categories = [];

        function listBooks(parameter) {
            if(arguments.length > 0) {
                if(typeof parameter.category !== 'undefined') {
                    return typeof categories[parameter.category] !== 'undefined' ?
                        categories[parameter.category].books : [];
                }

                if(typeof parameter.author !== 'undefined') {

                    var booksToList = [];

                    for(var i = 0, len = books.length; i < len; i += 1) {
                        if(books[i].author === parameter.author) {
                            booksToList.push(books[i]);
                        }
                    }

                    return booksToList;
                }
            }

            return books;
        }

        function checkAllBookParameters(book, arguments) {

            if(Object.keys(book).length !== arguments) {
                throw new Error('Error');
            }

            for (var param in book) {
                if(typeof book[param] === 'undefined') {
                    throw new Error('Error');
                }
            }
        }

        function addBook(book) {
            book.ID = books.length + 1;

            //4 own props + ID
            checkAllBookParameters(book, 5);

            validateISBN(book.isbn);
            validateAuthorISBN('title', book.title);
            validateAuthorISBN('isbn', book.isbn);
            validateTitleCategory(book.title);
            validateTitleCategory(book.category);

            if (book.author === '') {
                throw new Error('Error');
            };

            if(categories.indexOf(book.category) < 0) {
                addCategory(book.category);
            };

            categories[book.category].books.push(book);



            books.push(book);
            return book;
        }

        function listCategories(category) {

            var categoriesNames = [];
            Array.prototype.push.apply(categoriesNames, Object.keys(categories));

            return categoriesNames;
        }

        function addCategory(name) {
            categories[name] = {
                books: []
            };
        };



        function validateISBN(isbn) {
            //if (!(/\b\d{10}\b|\b\d{13}\b/g.test(isbn))) { - doesn't work, don't know why
            if (!(isbn.length === 10 || isbn.length === 13)) {
                throw new Error('Error')
            }
        }

        function validateAuthorISBN(type, name) {
            for(var i = 0, len = books.length; i < len; i += 1) {
                if(books[i][type] === name) {
                    throw new Error('Error')
                }
            }
        }

        function validateTitleCategory(name) {
            if (name.length < 2 || name.length > 100) {
                throw new Error('Error')
            }
        };

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };

    }());
    return library;
}
module.exports = solve;


