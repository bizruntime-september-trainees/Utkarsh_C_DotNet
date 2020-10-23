


let button = document.getElementById("fetch_btn");

button.addEventListener('click', buttonClickHandler);

function buttonClickHandler(){

    console.log("You've clicked fetch_btn !!");

    //  Instantiate an xhr 
    
    const xhr = new XMLHttpRequest();
     //        xhr object is used for async communication between client and server

                                        //     1. Sends data from the client in the background
                                        //      2. Receives the data from the server
                                        //      3. Updates the webpage without reloading it

    //  Open the object

    //.......Get Request..........
   // xhr.open('GET', 'https://jsonplaceholder.typicode.com/todos/1', true);

    //........Post request..............
    xhr.open('POST', 'http://dummy.restapiexample.com/api/v1/create', true);

    xhr.getResponseHeader('Content-type','application/json');

    //      What to do on progress?     

    xhr.onprogress = function(){
        console.log("On Progress !!");
    }

    xhr.onreadystatechange = function(){
        console.log("Ready state :"+xhr.readyState);
    }

    //  What to do when response is ready

    xhr.onload = function(){
        if(this.status == 200){
            console.log(this.responseText);
        }

        console.log("Some error occured")
      

//      Send the request

params = `{"name":"test","salary":"123","age":"23"}`;
        xhr.send(params);
    }
}


let pop_btn = document.getElementById("pop_btn");

pop_btn.addEventListener('click', popHandler);

function popHandler(){

    console.log("You've clicked fetch_btn !!");

    //  Instantiate an xhr 
    
    const xhr = new XMLHttpRequest();
     //        xhr object is used for async communication between client and server

                                        //     1. Sends data from the client in the background
                                        //      2. Receives the data from the server
                                        //      3. Updates the webpage without reloading it

    //  Open the object

   // .......Get Request..........
   xhr.open('GET', 'http://dummy.restapiexample.com/api/v1/employees', true);

    //........Post request..............
   // xhr.open('POST', 'http://dummy.restapiexample.com/api/v1/create', true);

   // xhr.getResponseHeader('Content-type','application/json');

   


    //  What to do when response is ready

    xhr.onload = function(){
        if(this.status == 200){
           
            let obj = JSON.parse(this.responseText); //.......String Response
            console.log(obj);
        }
else{
    console.log("Some error occured");
}
    }
        
//      Send the request

xhr.send();
console.log("We're done fetching employees");
        
    }

