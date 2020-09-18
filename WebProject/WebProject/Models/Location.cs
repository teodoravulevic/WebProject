namespace WebProject.Models
{
    public class Location
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public Address Address { get; set; }

        public Location(double longitude, double latitude, Address address)
        {
            Longitude = longitude;
            Latitude = latitude;
            Address = address;
        }
    }
}