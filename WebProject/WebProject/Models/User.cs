using System;
using WebProject.Models.Enums;

namespace WebProject.Models
{
    public abstract class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public RoleEnum Role { get; set; }

        public User(string username, string password, string name, string surname, string gender, DateTime dateOfBirth, RoleEnum role) 
        {
            Username = username;
            Password = password;
            Name = name;
            Surname = surname;
            Gender = gender;
            DateOfBirth = dateOfBirth.Date;
            Role = role;
        }
    }
}