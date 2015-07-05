/* Task Description */
/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    var Course = {
        init: function (title, presentations) {
            var homeworkId = 0,
                presentation,
                self = this;
            self.title = title;
            self.presentations = [];
            self.students = [];


            if (title[0] === ' ' || title[title.length - 1] === ' ') {
                throw Error();
            }

            if (!presentations.length) {
                throw Error();
            } else {
                presentations.forEach(function (title) {
                    if (/\s{2,}/.test(title) || title.length < 1 ||
                        title[0] === ' ' || title[title.length - 1] === ' ') {
                        throw Error();
                    }

                    presentation = {
                        title: title,
                        id: ++homeworkId
                    }
                    self.presentations.push(presentation);
                });
            }

            return this;
        },

        addStudent: function (name) {
            var self = this,
                firstName = name.split(' ')[0],
                lastName = name.split(' ')[1],
                student = {
                    firstname: firstName,
                    lastname: lastName,
                    //score: 0,
                    //visitExam: false,
                    //totalScore: 0,
                    id: self.students.length + 1
                };

            if (typeof name !== 'string') {
                throw Error();
            }
            if (name.split(' ').length === 1 || name.split(' ').length > 2) {
                throw Error();
            }
            if (!/^[A-Z][a-z]+\s[A-Z][a-z]*/.test(name)) {
                throw Error();
            }

            self.students.push(student);

            return student.id;
        },
        getAllStudents: function () {
            return this.students.slice(0);
        },
        submitHomework: function (studentID, homeworkID) {
            function validateId(id, objects) {
                var hasValidId = false;
                objects.forEach(function (obj) {
                    if (obj.id === id) {
                        hasValidId = true;
                        return;
                    }
                });

                if (!hasValidId) {
                    throw new Error();
                }
            }

            validateId(homeworkID, this.presentations);
            validateId(studentID, this.students);

            this.students.forEach(function (student) {
                if (student.id === studentID) {
                    if (student.homeworks === undefined) {
                        student.homeworks = 1;
                    } else {
                        student.homeworks += 1;
                    }
                }
            });

            return this;
        },
        pushExamResults: function (results) {
            var self = this;
            results.forEach(function (studentWithScore) {
                var studentId = studentWithScore.StudentID,
                    score = studentWithScore.score;

                if (isNaN(score) || !score) {
                    throw new Error();
                }

                if (!self.students[studentId - 1]) {
                    throw new Error();
                }

                if (self.students[studentId - 1].visitExam === true) {
                    throw new Error();
                }

                self.students[studentId - 1].visitExam = true;
                self.students[studentId - 1].score = score;
            });

            return self;
        },
        getTopStudents: function () {
            var topStudents;
            this.students.forEach(function (student) {
                student.totalScore = (25 * (student.homeworks / this.presentations.length)) + (0.75 * student.score);
            });

            this.students.sort(function (firstStudent, secondStudent) {
                return firstStudent.totalScore - secondStudent.totalScore;
            });

            topStudents = this.students.slice(0, 10);

            return topStudents;
        }
    };

    return Course;
}

module.exports = solve;
