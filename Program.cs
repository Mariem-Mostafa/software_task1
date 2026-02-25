
//  ===================================  Student Management System  =============================================
//----------------------------------------------------------------------------------------------------------------

﻿using System;
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
        static bool idDuplicated(int ID , Student[] students, int numOfStudent , Student currentStud) 
        {
            for (int i = 0; i < numOfStudent; i++)
            {
                if (students[i] != currentStud && students[i].ID == ID)  
                    return true; 
            }
            return false;
        }
        static int ReadInt(string message) {
            int number = 0 ;
            bool valid=false ;
            while (!valid)
            {
                Console.Write(message);
                try
                {
                    number = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch 
                {
                    Console.WriteLine("\n Invalid number, try again");
                }
            }
            return number ;
        }
        static void addStudent(Student st , Student[] students, int numOfStudent)
        {
            
             while (true) 
            {
                 st.ID = ReadInt("\nEnter Student ID: ");

                if (st.ID < 1000 || st.ID > 9999)
                    Console.WriteLine("\n ID must be 4 digits");
                else if (idDuplicated(st.ID, students, numOfStudent , st)) 
                    Console.WriteLine("\n ID already exists"); 
                else 
                    break;

            }

            Console.Write("\nEnter Student Name:");
            st.name = Console.ReadLine();

           
            st.level = ReadInt("\nEnter Student Level: ");

            Console.Write("\nEnter Student Department:");
            st.department =Console.ReadLine();

            bool validDouble = false;
            while (!validDouble)
            {
                Console.Write("\nEnter Student GPA:");
                try
                {
                    st.gpa = double.Parse(Console.ReadLine());
                    if (st.gpa < 0 || st.gpa > 4) 
                        Console.WriteLine("\n GPA must be between 0 and 4"); 
                    else
                        validDouble = true;
                }
                catch
                {
                    Console.WriteLine("\n Invalid number, try again");
                }
            }


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
            return stud.name == studName && stud.ID == id;
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
     
                selectionNumber = ReadInt(" \n Enter your selection number (choose from 1 to 6 ) : "); 
                     
                  
                if(selectionNumber == 1)  // Add Student operation
                {
                    students[numOfStudents] = new Student();
                    addStudent(students[numOfStudents], students, numOfStudents);
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
                    
                    int studID = ReadInt("\n Student ID : "); 

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
                    if(!found) Console.WriteLine("\nNot found"); 
                }

                else if (selectionNumber == 4)  // Update operation
                { 
                    int studID = ReadInt("\n Student ID : ");

                    Console.Write($"\n Student Name : ");
                    string studName = Console.ReadLine();
                    
                    for (int i = 0; i < numOfStudents; i++)
                    {
                        if (searchForAStudent(studID, studName, students[i]))
                        {
                           addStudent(students[i], students, numOfStudents);
                           break;
                        }

                    }
                }

                else if (selectionNumber == 5)  // Delete operation
                {
                    int studID = ReadInt("\n Student ID : ");
                    bool deleted=false;

                    Console.Write($"\n Student Name : ");
                    string studName = Console.ReadLine();

                    for (int i = 0; i < numOfStudents -1 ; i++)
                    {
                        if (searchForAStudent(studID, studName, students[i]))
                        {
                            while (i < numOfStudents -1) 
                            {
                                students[i] = students[i + 1];
                                i++;
                            }
                            students[numOfStudents-1] = null;
                            deleted = true;
                            break;
                        }

                    }
                    if(deleted)
                        numOfStudents--;
                    else
                        Console.WriteLine("\nNot Found");
                }


            } while (selectionNumber != 6);
      
        }
    }
}


/*
            double side = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The Area of the square : {0}", side * side);


            double triangleBase = int.Parse(Console.ReadLine());
            double triangleHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("The Area of the triangle : {0}", 0.5 * triangleBase * triangleHeight);
            */

            /*
            Console.WriteLine("What is your name ?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age ?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your country ?");
            string country = Console.ReadLine();
            Console.WriteLine("How meny member in your family ?");
            int fm = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your data :\n your name: {name}\n your age: {age}\n your county: {country}\n no of family member: {fm}");

        */
