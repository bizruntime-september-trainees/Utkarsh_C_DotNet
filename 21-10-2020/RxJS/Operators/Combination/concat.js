"use strict";
//      Join operators are Observable creation operators that also have join functionality: 
//      Emitting values of multiple Observables source
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var timer = rxjs_1.interval(1000).pipe(operators_1.take(4));
var sequence = rxjs_1.range(1, 10); //  Emits values from 1-10
var result = rxjs_1.concat(timer, sequence);
result.subscribe(function (x) { return console.log(x); });
// results in:
// 0 -1000ms-> 1 -1000ms-> 2 -1000ms-> 3 -immediate-> 1 ... 10
