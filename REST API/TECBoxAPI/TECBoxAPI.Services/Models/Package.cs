namespace TECBoxAPI.Services.Models
{
    public class Package
    {
        public int Tracking_Id { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Initial_Date { get; set; }
        public string Deliver_Date { get; set; }
        public int Id_Route { get; set; }
        public string District { get; set; }
        public int Dni_Client { get; set; }
        public int Dni_Employee { get; set; }
        
    }
}