"use strict";
// maps every source value to the same output value every time.
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var clicks = rxjs_1.fromEvent(document, 'click');
var greetings = clicks.pipe(operators_1.mapTo('Hi'));
greetings.subscribe(function (x) { return console.log(x); });
