using System;
using System.Collections.Generic;
using WebProject.Models.Enums;

namespace WebProject.Models
{
    public class Customer : User
    {
        public List<Ticket> Tickets { get; set; }
        public double Points { get; set; }
        public CustomerType Type { get; set; }

        public Customer(string username, string password, string name, string surname, string gender, DateTime dateOfBirth, RoleEnum role, CustomerType type) 
            : base(username, password, name, surname, gender, dateOfBirth, role)
        {
            Tickets = new List<Ticket>();
            Points = 0;
            Type = type;
        }
    }
}