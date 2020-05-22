namespace TECBoxAPI.Services.Models
{
    /**
     * Interfaz de estructura del Json de Rutas.
     */
    public class Route
    {
        public int Id { get; set; }
        public string[] District { get; set; }

        public string Name { get; set; }
        
    }
}