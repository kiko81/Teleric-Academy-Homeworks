function solve(){
  return function(){
    $.fn.listview = function(data){
      var templateHolder = this.attr('data-template'),
          template = $('#' + templateHolder).html(),
          container = handlebars.compile(template),
          i,
          len;

      for(i = 0, len = data.length; i < len; i += 1){
        this.append(container(data[i]));
      }

      return this;
    };
  };
}

module.exports = solve;