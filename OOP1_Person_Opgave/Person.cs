using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1PersonOpgave
{
    internal class Person
    {
        DateTime today = DateTime.Today;
        private string name;
        private DateTime dob;
        public bool checkTrue = true;
        public bool doesStringContain = true;       
        private string email;
        private string password;


        public string Name
        {
            get { return name; }
            set
            {
                if (value == "" || value.All(char.IsDigit)) doesStringContain = false;
                else doesStringContain = true;
            }
        }

        public string DoB
        {

            get { return dob.ToString(); }
            set
            {
                if (DateTime.TryParse(value, out dob)) checkTrue = false;
                else checkTrue = true;

            }
        }

        public int Age
        {
            get { return today.Year - dob.Year; }

        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains("@") && (value.Contains("."))) doesStringContain = true;
                else doesStringContain = false;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length > 7 && value.Any(char.IsUpper) && value.Any(char.IsLower) && value.Any(char.IsDigit) && !value.Contains(" ")) doesStringContain = true;
                else doesStringContain = false;
            }
        }

    }
}
