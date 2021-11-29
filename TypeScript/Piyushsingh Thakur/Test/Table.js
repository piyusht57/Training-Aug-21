"use strict";
exports.__esModule = true;
exports.Table = void 0;
var Table = /** @class */ (function () {
    function Table(id, rid, tname, Rname, TotalT, Available, Capacity) {
        this.Tid = id;
        this.Rid = rid;
        this.Tname = tname;
        this.Rname = Rname;
        this.TotalTable = TotalT;
        this.TAvailable = Available;
        this.TCapacity = Capacity;
    }
    Table.prototype.display = function (data1) {
        console.log("Displaying list of table");
        for (var _i = 0, data1_1 = data1; _i < data1_1.length; _i++) {
            var Table = data1_1[_i];
            console.log(Table);
        }
        console.log("");
        console.log("select the table");
        console.log("");
    };
    return Table;
}());
exports.Table = Table;
