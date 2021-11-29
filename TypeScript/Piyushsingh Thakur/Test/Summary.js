"use strict";
exports.__esModule = true;
exports.Summary = void 0;
var Summary = /** @class */ (function () {
    function Summary() {
    }
    Summary.prototype.bookinfo = function (d1) {
        console.log("summary of booking : ");
        for (var _i = 0, d1_1 = d1; _i < d1_1.length; _i++) {
            var r = d1_1[_i];
            console.log(r);
        }
    };
    return Summary;
}());
exports.Summary = Summary;
