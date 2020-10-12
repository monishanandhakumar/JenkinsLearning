using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDay1.Models;

namespace WebApiDay1.Controllers
{
    public class StudentController : ApiController
    {
        //1 Add student class in model 
      static  List<Student> students = new List<Student>() { new Student(101, "Sita", 24),new Student(102,"Sheela",25) };
        [HttpGet]
       //2
        public List<Student> GetAllStudents()
        {
            return students;
        }
        //3
        [HttpPost]
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        //4
        [HttpPut]
        public string EditStudent(int id,Student student)
        {
            string result = "Done";
            try
            {
                students[students.FindIndex(s => s.Id == id)] = student;
            }
            catch(Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        //5
        [HttpDelete]
        public string DeleteStudent(int id)
        {
            string result = "Done";
            try
            {
                students.Remove(students.Find(s => s.Id == id));
               // students[students.FindIndex(s => s.Id == id)] = student;
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
    }
}
