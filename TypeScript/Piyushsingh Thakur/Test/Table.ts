export class Table{

    Tid : number;
    Rid:number;
    Tname:string;
    Rname : string;
    TotalTable : number;
    TAvailable:number;
    TCapacity:number;

    constructor(id : number,rid:number,tname:string, Rname : string, TotalT : number,Available:number,Capacity:number){
        this.Tid = id;
        this.Rid=rid;
        this.Tname=tname;
        this.Rname = Rname;
        this.TotalTable = TotalT;
        this.TAvailable=Available;
        this.TCapacity=Capacity;
    }

    display(data1 : any) : any{
        console.log("Displaying list of table");

        for(var Table of data1){
            console.log(Table);
        }

        console.log("");
        console.log("select the table");   
        console.log("");
    }

}