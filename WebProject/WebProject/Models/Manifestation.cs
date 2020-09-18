using System;
using WebProject.Models.Enums;

namespace WebProject.Models
{
    public class Manifestation
    {
        public string Name { get; set; }
        public ManifestationTypeEnum Type { get; set; }
        public int SeatsAvailable { get; set; }
        public DateTime DateTime { get; set; }
        public double Price { get; set; }
        public ManifestationStatusEnum Status { get; set; }
        public Location Location { get; set; }
        public string ImagePath { get; set; }

        public Manifestation(string name, ManifestationTypeEnum type, int seatsAvailable, DateTime dateTime, 
            double price, ManifestationStatusEnum status, Location location, string imagePath)
        {
            Name = name;
            Type = type;
            SeatsAvailable = seatsAvailable;
            DateTime = dateTime;
            Price = price;
            Status = status;
            Location = location;
            ImagePath = imagePath;
        }
    }
}