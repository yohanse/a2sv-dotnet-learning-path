using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Student student = new Student("1", "yohanse", 23, 32, 100);
        Student student1 = new Student("2", "Z", 23, 32, 100);
        Student student2 = new Student("3", "Z", 23, 32, 100);
        Student student3 = new Student("4", "A", 23, 32, 100);
        Student student4 = new Student("5", "B", 23, 32, 100);
        Student student5 = new Student("6", "B", 23, 32, 100);

        StudentList<Student> studentList = new StudentList<Student>();
        studentList.Add(student);
        studentList.Add(student1);
        studentList.Add(student2);
        studentList.Add(student3);
        studentList.Add(student4);
        studentList.Add(student5);
        Console.WriteLine("Yohanse");
        studentList.Display();
        Console.WriteLine("--------------------");
        studentList.SearchByNameorAge("Z");
        Console.WriteLine("----------");
        studentList.SearchByNameorAge("1");
        Console.WriteLine("--------------------");
        Console.WriteLine(studentList.Xerilizer());
        
    }
}