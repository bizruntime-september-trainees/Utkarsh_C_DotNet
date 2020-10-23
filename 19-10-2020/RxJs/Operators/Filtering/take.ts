import { interval } from 'rxjs';
import {take} from 'rxjs/operators';

const numbers = interval(100); //...Creates an observable emitting 100 ascending values

const takeFourNumbers = numbers.pipe(take(4)); //.......Creates another observable taking first 4 values

takeFourNumbers.subscribe(x =>{
    console.log("Next: "+x);
    
});