using StudentSystem;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace StudentSystem
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"The student has Name: {Name} Age: {Age} Grade: {Grade}";
        }
    }
}
class StudentClass
{
    List<Student> students = new List<Student>();
    public void AddAStudentToList()
    {
        Console.WriteLine("Enter the information about student");
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter GPA: ");
        double gpa = double.Parse(Console.ReadLine());
        Student st1 = new Student(name, age, gpa);
        students.Add(st1);
    }
    public void Display()
    {
        foreach (var student in students)
        {
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Age: " + student.Age);
            Console.WriteLine("Grade: " + student.Grade);
            Console.WriteLine("-------------------");

        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        StudentClass class1 = new StudentClass();
        Console.WriteLine("Please choose from 1 to 3");
        Console.WriteLine("1. Creates a new student");
        Console.WriteLine("2. Prints information about a student");
        Console.WriteLine("3. Exit");
        Console.WriteLine("*********************************************************");
        Console.WriteLine("Please choose from 1 to 3");
        int option = int.Parse(Console.ReadLine());
        do
        {
            if (option == 1)
            {
                class1.AddAStudentToList();
            }
            else if (option == 2)
            {
                class1.Display();
            }
            else if (option == 3)
            {
                Console.WriteLine("GoodBye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please try again!");
            }

            Console.Write("Enter your choice: ");
            option = int.Parse(Console.ReadLine());
        }
        while (true);
        Console.ReadLine();
    }
}