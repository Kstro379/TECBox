namespace TECBoxAPI.Services.Models
{
    /**
     * Interfaz de estructura del Json de Sucursales.
     */
    public class Branch_Office
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Canton { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string In_charge { get; set; }
    }
    
}