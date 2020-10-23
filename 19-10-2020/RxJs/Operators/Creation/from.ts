//..................take() operator...................

// Creates an Observable instance from array object, an iterable object , A promise like object or from Observable object


import {from} from 'rxjs';

const array = [10,20,30];

const observable = from(array);

observable.subscribe(x =>{
    console.log("Value emitted: "+x);
})
