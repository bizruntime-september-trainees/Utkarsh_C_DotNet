
//  Creating Observables using new keyword and passing subscribe function in the argument of the construtor

const Observable = new Observable(function subscribe(subscriber){

    const id = setInterval(()=>{
subscriber.next('Hello');

        }, 1000);
})