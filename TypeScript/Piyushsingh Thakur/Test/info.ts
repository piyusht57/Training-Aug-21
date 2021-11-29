import {Summary} from "./Summary";
export class Booking{

    BookingID : number;
    TId:number;
    Rname:string;
    Tname:string;
    TCapasity:number
    Time:Date;

    constructor(bid : number, tid : number,tname:string, rname : string,capacity,time:Date){
        this.BookingID = bid;
        this.TId = tid;
        this.Rname = rname;
        this.Tname=tname;
        this.TCapasity=capacity;
        this.Time=time;
    }
    

    display(data : any) : any{

        var s1 = [];
        var report = new Summary;

        s1.push(data);
        
        report.bookinfo(s1);
    }
}
