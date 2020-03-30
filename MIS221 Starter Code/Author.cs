using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS221_Starter_Code
{
    class Author
    {
        private string name;
        private char gender;
        private string email;

        public Author(string tempName, char tempGender, string tempEmail)
        {
            this.name = tempName;
            this.gender = tempGender;
            this.email = tempEmail;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public char GetGender()
        {
            return gender;
        }

        public void SetGender(char gender)
        {
            this.gender = gender;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
           this.email = email;
        }
      
        public string ToString()
        {
            string temp = string.Format("name = " + name + ", gender = " + gender + ", email = " + email);
            return temp;
        }
    }
}
