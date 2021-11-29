export class Restaurant{

    Id : number;
    Rname : string;
    Radd : string;
    TotalTable:number;

    constructor(id : number, Rname : string, Radd : string,Table:number){
        this.Id = id;
        this.Rname = Rname;
        this.Radd = Radd;
        this.TotalTable=Table;
    }

    display(data : any) : any{
        console.log("Storing Restaurants data : ");

        for(var Restaurant of data){
            console.log(Restaurant);
        }

        console.log("");
        console.log("Starting Interview Process...");   
        console.log("");
    }

}