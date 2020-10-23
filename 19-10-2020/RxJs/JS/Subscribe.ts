
import {Observable} from 'rxjs';
const observable = new Observable(function subscribe(subscriber) 
{
    //      Passing subscribe function in the argument 

    try{
        subscriber.next(1); //  Observable pushes the values 1,2,3 immediately (synchronously)
        subscriber.next(2);
        subscriber.next(3);
    
        setTimeout(
        ()=>{

            subscriber.next(4); //........Push value '4' one second after the subscription
            subscriber.complete(); //.......stream completed
        }, 1000)
    }
    
    catch(err){
        subscriber.error(err);
    }
    
});

console.log('Just Before Subscribe');

//      Passing observer object in the subscribe method stating 3 functions 

var observer = {

    next(x) {
        console.log(x);
    },
    error(err){
        console.log(err);
    },

    complete(){
        console.log("Completed !!");
    }
    
}

observable.subscribe(observer);

console.log('Just after subscribe');


//........To invoke the observables and see these values , we have to subscribe to the Observable...............


