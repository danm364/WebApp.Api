namespace WebApp.Api.Entities
{
    public class CartItem
    {

        public int Id { get; set; } 

        public string CartId { get; set; }
        
        public int ProductId { get; set; }
        
        public int Qty { get; set; }    
    }
}
