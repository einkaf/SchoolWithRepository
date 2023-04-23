using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class StudentRepository : IEnumerable
    {
        public static StudentRepository repository = new StudentRepository();
        public static StudentRepository Current { get { return repository; } }

        private List<StudentModul>  std;



   



        public StudentRepository()
        {
            std = new List<StudentModul>();
        }

        public IEnumerator GetEnumerator()
        {
            yield return this;
        }

        public void AddStudent(string name, string surname, int age, bool alived)
        {
            StudentModul student = new StudentModul();
            student.Name = name;
            student.SurName = surname;
            student.Age = age;
            student.Exist = alived;
            std.Add(student);
        }

        public List<StudentModul> GetStudent()
        {
            return std;
        }

        public bool doesItExist(string lastname)
        {
            return std.Any(a=> a.SurName == lastname);
        }

        public void StudentIsExisted(string lastname) => std.Single(a => a.SurName == lastname).Exist = false;

        public void StudentIsExistedEdit(string name, string lastname, int age, string searchtest)
        {
            StudentModul test = std.Single(a => a.SurName == searchtest);
            test.Name = name;
            test.SurName = lastname;
            test.Age = age;
        }





    }
}
