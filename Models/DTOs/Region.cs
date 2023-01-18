namespace RegionsWalksAPI.Models.DTOs
{
    public class Region
    {
        public Guid Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public double Area { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public long Population { get; set; }
    }
}
