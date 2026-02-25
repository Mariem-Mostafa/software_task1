
Student Management System Documentation:
------------------------------------------

* This program is a simple student management system written in C#

* The program allows the user to manage student data, such as:
       - Adding a new student
       - Viewing all students
       - Searching for a student
       - Editing student data
       - Deleting a student
* Data is temporarily stored in an array of students while the program is running


 == System Features ==
--------------------------

1- Add Student : This function allows you to add a new student.
    - Inputs: Student ID , Name , Level , Department and GPA

    - Requirements:
        The ID must be 4 digits long.
       = The ID must not be duplicated.
       = The GPA must be between 0 and 4.
      
   - What happens: 1st -> Data is entered , 2nd -> Its validity is verified , then -> The student is saved in the array.


2- View All Students : This function allows you to view all stored students.
   - What happens: 1st The array is iterated through then Each student's data is displayed.


3- Search Student : This function allows you to search for a student.
   - Input:Student ID and Name

   - What happens:The search is performed within the array.
               -> If found : their data is displayed.
               -> If not found : the message "Not Found" appears.


4- Update Student : This function allows you to edit a student's data.
   - Input:Student ID and Name

   - What happens:The student is searched for .
               ->  If found : Data is re-entered and updated


5. Delete Student : This function allows you to delete a student.
   - Input:Student ID and Name

   - What happens:The student is searched for .
               ->  If found:
                   = The student is deleted.
                   = The array elements are moved.
               ->  If not found:
                   = Not Found
