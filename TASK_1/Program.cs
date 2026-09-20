using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1
{
    internal class Program
    {

        private static List<student> students = new List<student>();
        private static void List_Menu()
        {
            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("*****//students managing system//******");
            Console.WriteLine("Select one of the features:::");
            Console.WriteLine("1 Add Student");
            Console.WriteLine("2 View Students");
            Console.WriteLine("3 search Student");
            Console.WriteLine("4 delete student");
            Console.WriteLine("5 Show Students Above Grade");
            Console.WriteLine("6 Show Avg Grade");
            Console.WriteLine("7 exit");
            Console.WriteLine("**************************");
        }
        static void Main(string[] args)
        {
            bool ok = true;
            while (ok)
            {
                Console.WriteLine("Select one of the options pls");
                List_Menu();

                if (int.TryParse(Console.ReadLine(), out int c))
                {
                 // Console.WriteLine(c);
                    switch (c)
                    {
                        case 1: add_student(); break;
                        case 2: view_students(); break;
                        case 3: search_student(); break;
                        case 4: delete_student(); break;
                        case 5: show_student(); break;
                        case 6: show_avg(); break;
                        case 7: ok = false; Console.WriteLine("Thanks for using our system"); break;
                    }
                }
            }
        }
        
       
        private static void add_student()
        {
      
            int id;

            while (true)
            {
                Console.Write("enter the id: ");



                if (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("pease enter a number.");
                    continue;
                }



                if (id <= 0)
                {
                    Console.WriteLine("id mst be greater than zero.");
                    continue;
                }


                break;

              
            
            }
            string name;
            while (true)
            {
                Console.WriteLine("rnter the name of student");
                name = Console.ReadLine();

               
                if (!string.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                Console.WriteLine("name musnt be empty.");
               
            }
            int age;
            while (true)
            {
                Console.WriteLine("enter the studen age");

                if (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("pleas enter valid age.");
                    continue;
                }
                if (age <= 4 || age > 25)
                {
                    Console.WriteLine("age must be betweeen 4 and 25");
                    continue;
                }

                break;
            }
            float grade;
            while (true)
            {
                Console.WriteLine("enter the studen grade");

                if (!float.TryParse(Console.ReadLine(), out grade))
                {
                    Console.WriteLine("pleas enter valid grade");
                    continue;
                }
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("enter a valid grade 0-100");
                    continue;
                }

                break;
            }


            student student = new student(id, name, age, grade);
            students.Add(student);

            Console.WriteLine("student added -...-");
        }

        private static void view_students()
        {
            Console.WriteLine("the all users are here");
            foreach (student s in students)
            {
                Console.WriteLine($"id: {s.id}");
                Console.WriteLine($"name: {s.name}");
                Console.WriteLine($"age: {s.age}");
                Console.WriteLine($"grade: {s.grade}");
                Console.WriteLine("this is the information of student");
            }
            Console.WriteLine("return to the menu");
            Console.ReadLine();
        }
        private static void search_student()
        {
            Console.WriteLine("enter the is of required student");
            int iddd;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out iddd))
                {
                    Console.WriteLine("pleas enter valid id");
                    continue;
                }
                bool found = false;
                foreach (student s in students)
                {
                    if (s.id == iddd)
                    {
                        Console.WriteLine(s.name);
                        Console.WriteLine(s.age);
                        Console.WriteLine(s.grade);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Student not found");
                }

                Console.ReadLine();
                return;
            }
        }
        private static void delete_student()
        {
            Console.WriteLine("the deleting feature");
            Console.WriteLine("enter the id for the student you want to delete");
            int idd;
            while (true)
            {
                if (!int.TryParse (Console.ReadLine(), out idd))
                {
                    Console.WriteLine("pleas enter valid id");
                    continue;

                }
                bool found = false;
                foreach (student s in students)
                {
                    if (s.id == idd)
                    {
                      students.Remove(s);
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    Console.WriteLine("the user has removed");
                }
                else
                {
                    Console.WriteLine("the user id is not correct");
                }
                    Console.ReadLine();
                return;
            }
        }

        private static void show_student()
        {
            Console.WriteLine("enter the value of the grade");
            int gradee;
            while (true)
            {
                if(!int.TryParse(Console.ReadLine(),out gradee))
                {
                    Console.WriteLine("enter correct value");
                    continue;
                }
               //onsole.WriteLine(gradee);
                foreach(student s in students)
                {
                    int count = 0;
                    if (s.grade>gradee)
                    {
                        count++;
                        Console.WriteLine("the name of student above the grade is");
                        Console.WriteLine(s.name);
                    }
                }
                break;
                
            }
            
            Console.ReadLine();
            return;
        }

        private static void show_avg()
        {
            float sum = 0;
            int count = 0;
            foreach(student s in students)
            {
                ++count;
                sum += s.grade;
            }
            float avg = sum / count;
            Console.WriteLine("the average of the grades is");
            Console.WriteLine(avg);
            Console.ReadLine();
            return;
        }

    }
}

