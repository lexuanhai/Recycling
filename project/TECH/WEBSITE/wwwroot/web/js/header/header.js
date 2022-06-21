(function() {

   window.onscroll = function() {scrollFunction()};

    function scrollFunction() {
      if (document.body.scrollTop > 50 || document.documentElement.scrollTop > 50) {
        $(".box-menu").css("padding","10px 10px 10px 10px");
         $(".nav-link").css("font-size","14px"); 
         $(".navbar-branch.logo").css({"height":"50px","width":"136px"});
      } else {
         $(".box-menu").css("padding","20px 30px 20px 30px");
         $(".navbar-branch.logo").css({"height":"60px","width":"162px"}); 
         $(".nav-link").css("font-size","16px"); 
      }
    }
   
    $(document).ready(function () {
        $(".menu-mobile").click(function () {
            $("#boxSearch").show();
        })
        $(".uk-close").click(function () {
            $("#boxSearch").hide();
        })

    })
})();