// There is a retail shop which need to manage the inventory, whenever some purchase is being made product quantity should be reduced, if quantity is less than 5 reorder request should be raised. Design an interface and classes for the same.

// Interface for Property
interface Inventory{

    productId : number;
    productName : string;
    productCompany : string;
    productQty : number;
    productPrice : number;

}

class RetailShop implements Inventory{

    productId: number;
    productName: string;
    productCompany: string;
    productQty: number;
    productPrice: number;

    constructor(ID : number, Name : string, Comp : string, Qty : number, Price : number) {
        this.productId = ID;
        this.productName = Name;
        this.productCompany = Comp;
        this.productQty = Qty;
        this.productPrice = Price;
    }

}


var Product : RetailShop[] = [
    new RetailShop(1, "PC", "Dell", 7, 50000 ),
    new RetailShop(2, "Smart Phone", "Samsung", 6, 12000),
    new RetailShop(3, "Smart Watch", "MI", 8, 3000),
    new RetailShop(4, "Tablet", "Apple", 6, 15000)

]; 

function buy(Pname:string,Pquantity:number){
    Product.filter((value,index,arr)=>{
        if(value.productQty){
            if(value.productName==Pname){
                value.productQty=value.productQty-Pquantity;
            }
            else{
                console.log("please enter correct name");
                
            }
        }
        else{
            console.log("product is less than five");
            
        }
    })
}

buy("PC",6);
buy("Tablet",4)
console.log(Product);
