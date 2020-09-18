namespace WebProject.Models
{
    public class Address
    {
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int PostCode { get; set; }

        public Address(string streetName, int streetNumber, string city, int postCode)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            City = city;
            PostCode = postCode;
        }
    }
}