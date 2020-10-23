//      Join operators are Observable creation operators that also have join functionality: 
//      Emitting values of multiple Observables source


//          Concatinating 2 observables

import { concat, interval, range } from 'rxjs';
import { take } from 'rxjs/operators';

const timer = interval(1000).pipe(take(4));
const sequence = range(1, 10);      //  Emits values from 1-10

const result = concat(timer, sequence); // Concatinating above two observalbes
result.subscribe(x => console.log(x));


//          Concatinating 3 Observables     

const timer1 = interval(1000).pipe(take(5));
const timer2 = interval(2000).pipe(take(3));
const timer3 = interval(500).pipe(take(10));





