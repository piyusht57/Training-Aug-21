"use strict";
exports.__esModule = true;
exports.Restaurant = void 0;
var Restaurant = /** @class */ (function () {
    function Restaurant(id, Rname, Radd, Table) {
        this.Id = id;
        this.Rname = Rname;
        this.Radd = Radd;
        this.TotalTable = Table;
    }
    Restaurant.prototype.display = function (data) {
        console.log("Storing Restaurants data : ");
        for (var _i = 0, data_1 = data; _i < data_1.length; _i++) {
            var Restaurant = data_1[_i];
            console.log(Restaurant);
        }
        console.log("");
        console.log("Starting Interview Process...");
        console.log("");
    };
    return Restaurant;
}());
exports.Restaurant = Restaurant;
