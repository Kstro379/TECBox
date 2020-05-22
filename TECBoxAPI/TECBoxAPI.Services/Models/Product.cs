namespace TECBoxAPI.Services.Models
{
    /**
     * Interfaz de estructura del Json de Productos.
     */
    public class Product
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public float Tax { get; set; }
        public int Dni_Employee { get; set; }
        public int Dni_client { get; set; }
        public string Branch_Office { get; set; }
        
    }
}