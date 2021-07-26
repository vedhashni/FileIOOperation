using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    public class Person
    {
        public string name { get; set; }
        public string email { get; set; }
        public long phoneNum { get; set; }
        public string country { get; set; }

        public Person(string name, string email, long phoneNum, string country)
        {
            this.name = name;
            this.email = email;
            this.phoneNum = phoneNum;
            this.country = country;
        }
    }
}
