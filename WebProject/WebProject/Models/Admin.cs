using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProject.Models.Enums;

namespace WebProject.Models
{
    public class Admin : User
    {
        public Admin(string username, string password, string name, string surname, string gender, DateTime dateOfBirth, RoleEnum role) 
            : base(username, password, name, surname, gender, dateOfBirth, role) { }
    }
}