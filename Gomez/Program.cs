using System;

class Program
{
    List<Class> student = new List<Class>();
    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n===== STUDENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Student");
            Console.WriteLine("3. Compute Class Average");
            Console.WriteLine("4. Find Highest Grade");
            Console.WriteLine("5. Exit");
            Console.WriteLine("==========================");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                AddStud();
            }
            else if (choice == "2")
            {
                ViewStud();
            }
            else if (choice == "3")
            {
                AverageGrade();
            }
            else if (choice == "4")
            {
                FindHigh();
            }
            else if (choice == "5")
            {
                Console.WriteLine("\nExiting Program...");
                Console.WriteLine("Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option. ");
            }
        }
    }

    void AddStud()
    {
        Console.WriteLine("\nEnter Student name: ");
        string name = Console.ReadLine();

        List<int> grades = new List<int>();

        Console.Write("Enter grade 1: ");
        grades.Add(Convert.ToInt32(Console.ReadLine()));

        Console.Write("Enter grade 2: ");
        grades.Add(Convert.ToInt32(Console.ReadLine()));

        Console.Write("Enter grade 3: ");
        grades.Add(Convert.ToInt32(Console.ReadLine()));

        student.Add(new Class(name, grades));

        Console.WriteLine("Student added successfully!");

    }

    void ViewStud()
    {

        if (student.Count == 0)
        {
            Console.WriteLine("\nNo student records found.");
            return;
        }

        for (int i = 0; i < student.Count; i++)
        {
            Console.WriteLine("\nName: " + student[i].GetGrades());

            List<int> g = student[i].GetGrades();

            Console.WriteLine("Grades: " +
                g[0] + ", " +
                g[1] + ", " +
                g[2]);

            Console.WriteLine("Average: " + student[i].getAverage().ToString("F2"));
        }
    }

    void AverageGrade()
    {
        if (student.Count == 0)
        {
            Console.WriteLine("\nNo student records available.");
            return;
        }

        double totalAverage = 0;

        for (int i = 0; i < student.Count; i++)
        {
            totalAverage += student[i].getAverage();
        }

        Console.WriteLine("\n===== Class Average ===== ");
        Console.WriteLine("Overall Average Grade: " + (total.ToString("F2"));
    }

    void FindHigh()
    {
        if (student.Count == 0)
        {
            Console.WriteLine("\nNo student records Available.");
            return;
        }

        int highestGrade = student[0].Grades[0];
        string topStudent = student[0].name;

        for (int i = 0; i < student.Count; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (student[i].Grades[j] > highestGrade)
                {
                    highestGrade = student[i].Grades[j];
                    topStudent = student[i].name;
                }
            }
        }

        Console.WriteLine("\n===== HIGHEST GRADE =====");
        Console.WriteLine("\nTop Student: " + topStudent);
        Console.WriteLine("\nHighest Grade: " + highestGrade);

    }
}