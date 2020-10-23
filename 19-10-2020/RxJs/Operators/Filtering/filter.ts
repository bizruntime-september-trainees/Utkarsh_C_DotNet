import {  interval } from "rxjs";

import{take, filter} from 'rxjs/operators';

const observable = interval(1000).pipe(take(100)); //..  Creates an observable by Emitting ascending number every second.......

var observer = {
    next: function(value){
        console.log(value);
    },

    error: function(error){
        console.log("Error: "+error);
    }
    
}

observable.filter(function(value){
    return value %2 == 0;
}).subscribe(observer);



