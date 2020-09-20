using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using WebProject.Models.Enums;

namespace WebProject.Models
{
    public class Customer : User
    {
        public List<Ticket> Tickets { get; set; }
        public double Points { get; set; }
        public CustomerType Type { get; set; }

        private static readonly object padlock = new object();
        private static readonly string filePath = HttpContext.Current.Server.MapPath("~/App_Data/Customers.txt");

        public Customer(string username, string password, string name, string surname, string gender, DateTime dateOfBirth, RoleEnum role, CustomerType type) 
            : base(username, password, name, surname, gender, dateOfBirth, role)
        {
            Tickets = new List<Ticket>();
            Points = 0;
            Type = type;
        }

        public static List<Customer> GetAllCustomers()
        {
            lock (padlock)
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {

                }
            }

            return null;
        }

        public static Customer GetCustomer(string username)
        {
            lock (padlock)
            {
                return null;
            }
        }

        public static Customer UpdateCustomer(Customer customer)
        {
            lock (padlock)
            {
                return null;
            }
        }

        public static bool DeleteCustomer(string username)
        {
            lock (padlock)
            {
                return true;
            }
        }

        public static Customer AddCustomer(Customer customer)
        {
            lock (padlock)
            {
                return null;
            }
        }
    }
}