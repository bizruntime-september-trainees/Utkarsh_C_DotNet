

//      Emits the values emitted by the source Observable until a notifier Observable emits a value.

//      Tick every second until the first click happens

// takeUntil() subscribes and begins mirroring the source observables and it also monitors a second observable called 'notifier'

import { fromEvent, interval } from 'rxjs';
import { takeUntil } from 'rxjs/operators';


const source = interval(1000); //           Source observable
const clicks = fromEvent(document, 'click'); // notifier observable
const result = source.pipe(takeUntil(clicks));
result.subscribe(x => console.log(x));