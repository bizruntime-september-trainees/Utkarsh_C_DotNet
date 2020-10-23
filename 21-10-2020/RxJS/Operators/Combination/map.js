"use strict";
exports.__esModule = true;
// RxJS v6+
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
//emit (1,2,3,4,5)
var source = rxjs_1.from([1, 2, 3, 4, 5]);
//add 10 to each value
var example = source.pipe(operators_1.map(function (val) { return val + 10; }));
//output: 11,12,13,14,15
var subscribe = example.subscribe(function (val) { return console.log(val); });
