namespace TECBoxAPI.Services.Models
{
    /**
     * Interfaz de estructura del Json de Roles.
     */
    public class Role
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int[] Dni_Employee { get; set; }
        
    }
}