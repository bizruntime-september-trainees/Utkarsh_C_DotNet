"use strict";
//..................take() operator...................
exports.__esModule = true;

// Creates an Observable instance from array object, an iterable object , A promise like object or from Observable object
var rxjs_1 = require("rxjs");
var array = [10, 20, 30];
var observable = rxjs_1.from(array);
observable.subscribe(function (x) {
    console.log("Value emitted: " + x);
});
