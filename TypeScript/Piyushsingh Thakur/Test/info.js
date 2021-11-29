"use strict";
exports.__esModule = true;
exports.Booking = void 0;
var Summary_1 = require("./Summary");
var Booking = /** @class */ (function () {
    function Booking(bid, tid, tname, rname, capacity, time) {
        this.BookingID = bid;
        this.TId = tid;
        this.Rname = rname;
        this.Tname = tname;
        this.TCapasity = capacity;
        this.Time = time;
    }
    Booking.prototype.display = function (data) {
        var s1 = [];
        var report = new Summary_1.Summary;
        s1.push(data);
        report.bookinfo(s1);
    };
    return Booking;
}());
exports.Booking = Booking;
