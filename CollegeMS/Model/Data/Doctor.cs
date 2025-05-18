using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeMS.Model.Interfaces;
namespace CollegeMS.Model.Data
{
    public class Doctor : Person, BaseDataModel
    {
        public int id { get  ; set  ; }
        public string Name { get  ; set  ; }
        public string Password { get; set; }
        public string Email { get  ; set  ; }
        public DateTime BirthDate { get  ; set  ; }
        public string Role { get  ; set  ; }
        public Course Course { get; set; }
        public Doctor()
        {

        }
        public Doctor(int id, string name, string email, DateTime birthDate, string role)
        {
            this.id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Role = role;
        }
    }
}
