/* globals $ */

/* 

 Create a function that takes an id or DOM element and:

 If an id is provided, select the element
 Finds all elements with class button or content within the provided element
 Change the content of all .button elements with "hide"
 When a .button is clicked:
 Find the topmost .content element, that is before another .button and:
 If the .content is visible:
 Hide the .content
 Change the content of the .button to "show"
 If the .content is hidden:
 Show the .content
 Change the content of the .button to "hide"
 If there isn't a .content element after the clicked .button and before other .button, do nothing
      Throws if:
 The provided DOM element is non-existant
 The id is either not a string or does not select any DOM element


*/

function solve(){
  return function (selector) {
      var buttons,
          i,
          len,
          content;

    if (!selector) {
      throw '';
    }

    selector = document.getElementById(selector);

    if (!selector) {
      throw '';
    }

      buttons = selector.getElementsByClassName('button');

      for (i = 0, len = buttons.length; i < len; i+=1) {

          buttons[i].innerHTML = 'hide';
          buttons[i].addEventListener('click', onBtnClick, false);
      }

      function onBtnClick() {
          var nextContent = this.nextElementSibling,
              nextBtn = this.nextElementSibling;

          while (nextContent.className !== 'content') {
              nextContent = nextContent.nextElementSibling;
          }

          //if (nextContent && nextContent.className === 'content') {
              while (nextBtn.className !== 'button') {
                  nextBtn = nextBtn.nextElementSibling;
              }
          //}

          if (nextBtn.className === 'button') {
              var that = this;
              if (nextContent.style.display === 'none') {
                  nextContent.style.display = '';
                  this.innerHTML = 'hide';
                  while (that.nextElementSibling.className === 'button') {
                      that.nextElementSibling.innerHTML = 'hide';
                      that = that.nextElementSibling;
                  }
                  that = this;
                  while (that.previousElementSibling.className === 'button') {
                      that.previousElementSibling.innerHTML = 'hide';
                      that = that.previousElementSibling;
                  }

              } else {
                  nextContent.style.display = 'none';
                  this.innerHTML = 'show';
                  while (that.nextElementSibling.className === 'button') {
                      that.nextElementSibling.innerHTML = 'show';
                      that = that.nextElementSibling;
                  }
                  that = this;
                  while (that.previousElementSibling.className === 'button') {
                      that.previousElementSibling.innerHTML = 'show';
                      that = that.previousElementSibling;
                  }
              }
          }
      }
  };
};

module.exports = solve;