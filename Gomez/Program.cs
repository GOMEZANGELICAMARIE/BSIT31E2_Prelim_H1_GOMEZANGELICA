using System;

class Program
{
    private List<Class> student = new List<>(Class);

        static void Main()
        {
            Program p = new Program();
            p.Start();
        }

       void Start()
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
                    AddStud();
                else if (choice == "2")
                    ViewStud();
                else if (choice == "3")
                    AverageGrade();
                else if (choice == "4")
                    FindHigh();
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
            Console.WriteLine("\nName: " + student[i].GetName());

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

        double overall = totalAverage / student.Count;

        Console.WriteLine("\n===== Class Average ===== ");
        Console.WriteLine("Overall Average Grade: " + (overall.ToString("F2"));
    }

    void FindHigh()
    {
        if (student.Count == 0)
        {
            Console.WriteLine("\nNo student records Available.");
            return;
        }

        student topStudent = student[0];
        int highest = student[0].GetGrades()[0];

        for (int i = 0; i < student.Count; i++)
        {
            List<int> g = student[i].GetGrades();

            for (int j = 0; j < g.Count; j++)
            {
                if (g[j] > highest)
                {
                    highest = g[j].Grades[j];
                    topStudent = student[i];
                }
            }
        }

        Console.WriteLine("\n===== HIGHEST GRADE =====");
        Console.WriteLine("\nTop Student: " + topStudent);
        Console.WriteLine("\nHighest Grade: " + highestGrade);

    }
}