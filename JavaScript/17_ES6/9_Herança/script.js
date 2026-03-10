//Herança extende uma classe a outra

//Utilizamos extends para referir a classe herdada

//E as propriedades sao enviadas via super



class Product {
    constructor(name, price){
        this.name = name
        this.price = price
    }

    productWithDiscount(discount){
        return this.price * ((100 - discount) / 100)
    }
}

const shirt = new Product("Camisa gola v", 20)






class productWithAttributes extends Product{
    constructor(name, price, colors){
        super(name, price)
        this.colors = colors
    }

showColors(){
    console.log("As cores são:")
    this.colors.forEach((color)=>{
        console.log(color)
    })
}

}

const hat = new productWithAttributes("Chapeu", 29.99, [
    "Preto", 
    "Azul", 
    "Verde"
])
console.log(hat.name)
console.log(hat.productWithDiscount(30))
hat.showColors();
