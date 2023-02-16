using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
     public class UserClass
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Password { get; set; }

        public UserClass(string name, string sex, DateTime? birthDate, string password)
        {
            this.Name = name;
            this.Sex = sex;
            this.BirthDate = birthDate;
            this.Password = password;
        }

    }
}
