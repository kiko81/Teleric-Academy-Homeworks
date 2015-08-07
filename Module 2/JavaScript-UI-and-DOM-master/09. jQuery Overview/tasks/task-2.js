/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
  return function (selector) {
    var element = $(selector),
        buttons = $('.button'),
        content = $('.content'),
        i,
        len;

    if (typeof(selector) !== 'string' || element.length === 0) {
      throw 'invalid selector';
    }

    buttons.text('hide')
           .on('click', function () {
      var target = $(this),
          nextContent = target.next(),
          nextBtn = target.next();

      while (!nextContent.hasClass('content')) {
        nextContent = nextContent.next();
      }

      while (!nextBtn.hasClass('button')) {
        nextBtn = nextBtn.next();
      }

      if (nextBtn.hasClass('button')) {
        if (nextContent.css('display') === 'none') {
          nextContent.css('display',  '');
          target.text('hide');
          while (target.next().hasClass('button')) {
            target.next().text('hide');
            target = target.next();
          }
          target = $(this);
          while (target.prev().hasClass('button')) {
            target.prev().text('hide');
            target = target.prev();
          }

        } else {
          nextContent.css('display',  'none');
          target.text('show');
          while (target.next().hasClass('button')) {
            target.next().text('show');
            target = target.next();
          }
          target = $(this);
          while (target.prev().hasClass('button')) {
            target.prev().text('show');
            target = target.prev();
          }
        }
      }
    })
  };
};

module.exports = solve;