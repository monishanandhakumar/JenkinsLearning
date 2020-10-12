using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDay1.Models
{
    /*[Serializable]*/
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //dependency resolver .controller factory does not find the default constructor to invoke action method
       public Student()
        {

        }

        public Student(int Id,string Name,int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
    }
}