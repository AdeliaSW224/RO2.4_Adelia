using System;
using System.Collections.Generic;

class Student
{
    private static int counter = 1;

    public int StudentId;
    public string Name;
    public double GPA;
    public string Faculty;

    public Student(string name, double gpa, string faculty)
    {
        Name = name;
        Faculty = faculty;

        GPA = gpa;

        StudentId = counter;
        counter++;
    }

    public void Print()
    {
        Console.WriteLine($"student id: {StudentId}, name: {Name}, gpa: {GPA}, faculty: {Faculty}");
    }
}

class Registry
{
    private Student[] students = new Student[100];
    private int count = 0;

    public void Add(Student s)
    {
        if (count < 100)
        {
            students[count] = s;
            count++;
            Console.WriteLine("Student added");
        }
        else
        {
            Console.WriteLine("Registry full");
        }
    }

    public Student FindById(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (students[i].StudentId == id)
                return students[i];
        }
        return null;
    }

    public List<Student> FindByName(string name)
    {
        List<Student> result = new List<Student>();

        for (int i = 0; i < count; i++)
        {
            if (students[i].Name == name)
                result.Add(students[i]);
        }

        return result;
    }

    public List<Student> GetTopStudents(int n)
    {
        List<Student> temp = new List<Student>();

        for (int i = 0; i < count; i++)
            temp.Add(students[i]);

        temp.Sort((a, b) => b.GPA.CompareTo(a.GPA));

        if (n > temp.Count)
            n = temp.Count;

        return temp.GetRange(0, n);
    }

    public void PrintAll()
    {
        if (count == 0)
        {
            Console.WriteLine("No students");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            var s = students[i];
            s.Print();
        }
    }
}


class Program
{
    static void Main()
    {
        Registry reg = new Registry();

        while (true)
        {
            Console.WriteLine("\n1 Add");
            Console.WriteLine("2 Find by ID");
            Console.WriteLine("3 Find by Name");
            Console.WriteLine("4 Top students");
            Console.WriteLine("5 Print all");
            Console.WriteLine("6 Exit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("GPA: ");
                double gpa;
                bool isVaildDouble = double.TryParse(Console.ReadLine(), out gpa);
                while (!isVaildDouble || gpa < 0 || gpa > 4)
                {
                    Console.Write("Enter GPA again (0-4): ");
                    isVaildDouble = double.TryParse(Console.ReadLine(), out gpa);
                }

                Console.Write("Faculty: ");
                string faculty = Console.ReadLine();

                Student s = new Student(name, gpa, faculty);
                reg.Add(s);
            }
            else if (choice == "2")
            {
                Console.Write("ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                var s = reg.FindById(id);
                if (s != null)
                    s.Print();
                else
                    Console.WriteLine("Not found");
            }
            else if (choice == "3")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                var list = reg.FindByName(name);

                if (list.Count == 0)
                    Console.WriteLine("No students found");
                else
                    foreach (var s in list)
                        s.Print();
            }
            else if (choice == "4")
            {
                Console.Write("How many: ");
                int n = Convert.ToInt32(Console.ReadLine());

                var top = reg.GetTopStudents(n);

                foreach (var s in top)
                    s.Print();
            }
            else if (choice == "5")
            {
                reg.PrintAll();
            }
            else if (choice == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong choice");
            }
        }
    }
}
