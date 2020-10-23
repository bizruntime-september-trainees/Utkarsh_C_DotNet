

//   An Observable that delays the emissions of the source Observable by the specified dueTime
//      But drops previous pending delayed emmisions if new value arrives.
//      Keeps track of the most recent value from the Observable


import { fromEvent } from 'rxjs';
import { debounceTime } from 'rxjs/operators';

const clicks = fromEvent(document, 'click');
const result = clicks.pipe(debounceTime(1000));
result.subscribe(x => console.log(x));