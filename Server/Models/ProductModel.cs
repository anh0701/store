namespace Server.Models{
    public class ProductVM{
        public required string name {get; set;}
        public double cost {get; set;}
    }
    public class Product: ProductVM{
        public Guid id {get; set;}
    }
}