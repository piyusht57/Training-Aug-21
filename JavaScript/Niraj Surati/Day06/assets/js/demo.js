let newJSONData = {
	"products": [{
		"Name": "Cheese",
		"Price": 2.50,
		"Location": "Refrigerated foods"
	}, {
		
		"Name": "Crisps",
		"Price": 3,
		"Location": "the Snack isle"
	}, {
		"Name": "Pizza",
		"Price": 4,
		"Location": "Refrigerated foods"
	}, {
		"Name": "Chocolate",
		"Price": 1.50,
		"Location": "the Snack isle"
	}, {
		"Name": "Self - raising flour",
		"Price": 1.50,
		"Location": "Home baking"
	}, {
		"Name": "Ground almonds",
		"Price": 3,
		"Location": "Home baking"
	}]
}


// //display json and parse and table



for(let row of newJSONData.products){
    console.log(row);
    for(col in row){
        console.log(row[col])
    }
}
