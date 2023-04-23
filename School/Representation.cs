using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace School
{
    public static class Representation
    {
        public static StudentRepository student = StudentRepository.Current;
        
        public static void StudentMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t- Main Menu -\n");
            Console.WriteLine(new string('~', 50));
            Console.WriteLine("\n\tA) Add Student\n");
            Console.WriteLine("\n\tP) Print Student\n");
            Console.WriteLine("\n\tD) Delete Student\n");
            //Console.WriteLine("\n\tE) Edite Student\n");

            Console.WriteLine("\n\tEscape) Exit\n");
        }

        public static void WrongInput()
        {
            Console.Clear();
            Console.WriteLine("Wrong input, try again");
            Console.ReadKey();
            
        }

        public static void Add()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t- Add Menu -\n");
            Console.WriteLine(new string('~', 50));
            Console.Write("\n\tInsert the firstname of the Student : ");
            string insertFirstname = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\n\t\t- Add Menu -\n");
            Console.WriteLine(new string('~', 50));
            Console.Write("\n\tInsert the lastname of the Student : ");
            string insertLastname = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\n\t\t- Add Menu -\n");
            Console.WriteLine(new string('~', 50));
            Console.Write("\n\tInsert the age the Student : ");
            int age = Convert.ToInt16(Console.ReadLine());
            bool alieved = true;

            student.AddStudent(insertFirstname, insertLastname, age, alieved);
            Console.Clear();
            Console.WriteLine("\n\n\tInformation has been successfully saved...");
            Console.ReadKey();

        }
        public static void Print()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t- Print Menu -\n");
            Console.WriteLine(new string('~', 50));
            foreach (var item in student.GetStudent())
            {
                if (item.Exist==true)
                {
                    Console.WriteLine(item.Name +" / " + item.SurName + " / " + item.Age);
                    Console.WriteLine(new string('~', 50));
                }

            }
            Console.ReadKey(true);
        }

        public static void Delete()
        {
            
            Console.Clear();
            Console.WriteLine("\n\t\t- Delete Menu -\n");
            Console.WriteLine(new string('~', 50));

            Console.Write("\n\tInset the last name of the student, whose you want to Delete: ");
            string searchLastname = Console.ReadLine();
            Console.Clear();
            bool test = student.doesItExist(searchLastname);
            if (test)
            {

                student.StudentIsExisted(searchLastname);
                Console.Clear();
                Console.Write("\n\tHas deleted!");

            }

            if (!test)
            {
                Console.Clear();
                Console.Write("\n\tDoes Not Exist");
            }
            Console.ReadKey();
        }


        public static void Edite()
        {

            Console.Clear();
            Console.WriteLine("\n\t\t- Edite Menu -\n");
            Console.WriteLine(new string('~', 50));

            Console.Write("\n\tInset the last name of the student, whose you want to Edit: ");
            string searchLastname = Console.ReadLine();
            Console.Clear();
            bool test = student.doesItExist(searchLastname);
            if (test)
            {
                Console.Clear();
                Console.WriteLine("\n\t\t- Edite Menu -\n");
                Console.WriteLine(new string('~', 50));
                Console.Write("\n\tInsert the new firstname of the Student : ");
                string insertFirstname = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("\n\t\t- Edite Menu -\n");
                Console.WriteLine(new string('~', 50));
                Console.Write("\n\tInsert the new lastname of the Student : ");
                string insertLastname = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("\n\t\t- Edite Menu -\n");
                Console.WriteLine(new string('~', 50));
                Console.Write("\n\tInsert the new age the Student : ");
                int age = Convert.ToInt16(Console.ReadLine());

                student.StudentIsExistedEdit(insertFirstname, insertLastname, age, searchLastname);
                Console.Clear();
                Console.WriteLine("\n\n\tInformation has been successfully saved...");
                Console.ReadKey();

            }

            if (!test)
            {
                Console.Clear();
                Console.Write("\n\tDoes Not Exist");
            }
            Console.ReadKey();
        }
    }
}
