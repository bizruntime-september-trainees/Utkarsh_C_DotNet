"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var numbers = rxjs_1.interval(100); //...Creates an observable emitting 100 ascending values
var takeFourNumbers = numbers.pipe(operators_1.take(4)); //.......Creates another observable taking first 4 values
takeFourNumbers.subscribe(function (x) {
    console.log("Next: " + x);
});
