using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
   
        public class Students
        {
            public string username, surname, email, password, school;
            public int mobilePhone, Grade, Gender, ID;

            public Students(string username, string surname, string email, string password, string school, int mobilePhone, int Grade, int Gender,int ID)
            {
                this.username = username;
                this.surname = surname;
                this.email = email;
                this.password = password;
                this.school = school;
                this.mobilePhone = mobilePhone;
                this.Grade = Grade;
                this.Gender = Gender;
                this.ID = ID;
            }
        }
    
}
