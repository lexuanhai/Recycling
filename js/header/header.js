(function() {

   window.onscroll = function() {scrollFunction()};

    function scrollFunction() {
      debugger;
      if (document.body.scrollTop > 50 || document.documentElement.scrollTop > 50) {
        $(".box-menu").css("padding","10px 10px 10px 10px");
         $(".nav-link").css("font-size","14px"); 
         $(".navbar-branch.logo").css({"height":"50px","width":"136px"});
      } else {
         $(".box-menu").css("padding","20px 50px 20px 50px");
         $(".navbar-branch.logo").css({"height":"60px","width":"162px"}); 
         $(".nav-link").css("font-size","17px"); 
      }
    }
})();