using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace My_Frist_Code
{


    class Student
    {   public int ID;
        public string name;
        public int level;
        public string department;
        public double gpa;
        }
    class Program
    {
        static void addStudent(Student st)
        {
            Console.Write("\nEnter Student ID:");
            st.ID =int.Parse(Console.ReadLine());

            Console.Write("Enter Student Name:");
            st.name = Console.ReadLine();

            Console.Write("Enter Student Level:");
            st.level = int.Parse(Console.ReadLine());
            
            Console.Write("Enter Student Department:");
            st.department =Console.ReadLine();

            Console.Write("Enter Student GPA:");
            st.gpa = double.Parse(Console.ReadLine());
        }

        static void showStudents(Student st)
        {
            Console.WriteLine($"\n Student ID : {st.ID}");
            Console.WriteLine($" Student Name : {st.name}");
            Console.WriteLine($" Student Level : {st.level}");
            Console.WriteLine($" Student Department : {st.department}");
            Console.WriteLine($" Student GPA : {st.gpa}");

            Console.WriteLine("\n -------------------\n");

        }

        static bool searchForAStudent(int id ,string studName,Student stud) 
        {  
            bool found=false;
            if (stud.name == studName && stud.ID == id ) found=true;
          
            return found;
        }
        
        static void Main(string[] args)
        {
            Student[] students = new Student[100];
            int numOfStudents = 0;
            int selectionNumber;

            do 
            {
                Console.WriteLine("\n    =====  Welcome  =====   ");
                Console.WriteLine("   -----------------------   ");
                Console.WriteLine("\n 1. Add Student \n 2. View All \n 3. Search \n 4. Update \n 5. Delete \n 6. Exit");
                
                Console.Write("\n Enter your selection number : ");
                selectionNumber = int.Parse(Console.ReadLine());
                
                if(selectionNumber == 1)  // Add Student operation
                {
                    students[numOfStudents] = new Student();
                    addStudent(students[numOfStudents]);
                    numOfStudents++;
                }

                else if (selectionNumber == 2)  // View All operation
                {
                    Console.WriteLine("\n -------------------\n");
                    for (int i = 0; i < numOfStudents; i++) 
                    {
                        showStudents(students[i]);
                       
                    }
                }

                else if (selectionNumber == 3)  // Search operation
                { 
                    Console.Write($"\n Student ID : ");
                    int studID = int.Parse(Console.ReadLine());

                    Console.Write($"\n Student Name : ");
                   
                    string studName = Console.ReadLine();
                    bool found=false;
                   
                    for (int i = 0; i < numOfStudents; i++)
                    {
                         if (searchForAStudent(studID, studName, students[i]))
                         {
                            found = true;
                            showStudents(students[i]);
                            break;
                         }
              
                    }
                    if(!found) Console.WriteLine("Not found"); 
                }

                else if (selectionNumber == 4)  // Update operation
                { 
                    Console.Write($"\n Student ID : ");
                    int studID = int.Parse(Console.ReadLine());

                    Console.Write($"\n Student Name : ");
                    string studName = Console.ReadLine();
                    
                    for (int i = 0; i < numOfStudents; i++)
                    {
                        if (searchForAStudent(studID, studName, students[i]))
                        {
                           addStudent(students[i]);
                           break;
                        }

                    }
                }

                else if (selectionNumber == 5)  // Delete operation
                {
                    Console.Write($"\n Student ID : ");
                    int studID = int.Parse(Console.ReadLine());

                    Console.Write($"\n Student Name : ");
                    string studName = Console.ReadLine();

                    for (int i = 0; i < numOfStudents-1 ; i++)
                    {
                        if (searchForAStudent(studID, studName, students[i]))
                        {
                            while (i < numOfStudents) 
                            {
                                students[i] = students[i + 1];
                                i++;
                            }
                            students[numOfStudents-1] = null;
                            break;
                        }

                    }
                    numOfStudents--;
                }


            } while (selectionNumber != 6);
      
        }
    }
}

