/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName`, `age` and `marks` properties
        *   `marks` is an array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (students) {
    var student = _.chain(students).map(function(item){
      item.fullName = item.firstName + ' ' + item.lastName;
      var sum = 0,
          i,
          len;
      for(i = 0, len = item.marks.length; i < len; i += 1){
        sum += item.marks[i];
      }

      item.averageMark = sum/len;
      return item;
    }).sortBy('averageMark').last().value();
    console.log(student.fullName + ' has an average score of ' + student.averageMark);
  };
}

module.exports = solve;
