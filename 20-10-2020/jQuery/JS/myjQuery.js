$(document).ready(function () { //    When document is ready/page is fully loaded then only execute jquery/Javascript

    // $('p').click(); //...........   Click on all paragraph function .............



    // console.log(jQuery);


 // .................. jQuery Syntax......................

 //  $('selector').action()





 //$('p').click(); //        Click on p




//...................           ID  Selector        ......................

// $('#second').click();


// //......................        Class  Selector     .................

// $('.odd').click();


   

     $('p').click(function () {
         console.log('You clicked on p');
     }); //        ......................Do this when clicked on p................



   $(this).hide(); //      ................this keyword as selector................

    // $('#second').hide();
    // $('.class').hide();


    // //.............         Miscellaneous Selectors     .................


              //........Clicks on all the elements ................

//  $('*').click();          
//$('p.odd').click();
 });

