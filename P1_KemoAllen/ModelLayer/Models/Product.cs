using System.ComponentModel.DataAnnotations;
using System;
namespace ModelLayer
{
    public class Product
    {
        //Constructor
        public Product(){

        }
        public Product(string name, decimal unitPrice){
            this.description = name;
            this.unitPrice = unitPrice;
            //this.quantity = quantity;
        }
        //Product id
        [Key]
        public Guid productId {get; set;} = Guid.NewGuid();
        
        //Price of 1 item
        private decimal unitPrice { get; set;}
        public decimal UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        //Quantity
        // private int quantity { get; set;}
        // public int Quantity
        // {
        //     get { return quantity; }
        //     set { quantity = value; }
        // }
        
        
        //Description
        private string description { get; set;}
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //Total cost of all items of available quantity
        // private double price;
        // public double Price
        //  { 
        //     get { return price; } 
        //     set {price = unitPrice * quantity;}
        //  }

        public override string ToString()
        {
            return description;
        }
    }
}
//run foreach loop and add 