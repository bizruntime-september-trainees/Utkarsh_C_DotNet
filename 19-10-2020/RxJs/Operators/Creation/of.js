"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
rxjs_1.of(10, 20, 30)
    .subscribe(function (next) { return console.log('next:', next); }, function (err) { return console.log('error:', err); }, function () { return console.log('the end'); });
