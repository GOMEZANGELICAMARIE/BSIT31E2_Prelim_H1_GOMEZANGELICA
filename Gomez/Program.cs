using System;

class Program
{
    static List<string> studentNames = new List<string>();
    static List<List<int>> studentGrades = new List<List<int>>();
    static int studentCount = 0;

    static void Main()
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

    static void AddStud()
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

        studentNames.Add(name);
        studentGrades.Add(grades);

        Console.WriteLine("Student added successfully!");

    }

    static void ViewStud()
    {

        if (studentNames.Count == 0)
        {
            Console.WriteLine("\nNo student records found.");
            return;
        }

        Console.WriteLine("\n===== STUDENT SYSTEM =====");

        for (int i = 0; i < studentNames.Count; i++)
        {
            double average =
                (studentGrades[i][0] +
                 studentGrades[i][1] +
                 studentGrades[i][2]) / 3.0;

            Console.WriteLine("\nName: " + studentNames[i]);
            Console.WriteLine("Grades: " +
                studentGrades[i][0] + ", " +
                studentGrades[i][1] + ", " +
                studentGrades[i][2]);

            Console.WriteLine("Average: " + average.ToString("F2"));
        }
    }

    static void AverageGrade()
    {
        if (studentNames.Count == 0)
        {
            Console.WriteLine("\nNo student records available.");
            return;
        }

        double totalAverage = 0;

        for (int i = 0; i < studentNames.Count; i++)
        {
            double average =
                (studentGrades[i][0] +
                 studentGrades[i][1] +
                 studentGrades[i][2]) / 3.0;

            totalAverage += average;
        }

        double overallAverage = totalAverage / studentNames.Count;
        Console.WriteLine("\n===== Class Average ===== ");
        Console.WriteLine("Overall Average Grade: " + overallAverage.ToString("F2"));
    }

    static void FindHigh()
    {
        if (studentNames.Count == 0)
        {
            Console.WriteLine("\nNo student records Available.");
            return;
        }

        int highestGrade = studentGrades[0][0];
        string topStudent = studentNames[0];

        for (int i = 0; i < studentNames.Count; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (studentGrades[i][j] > highestGrade)
                {
                    highestGrade = studentGrades[i][j];
                    topStudent = studentNames[i];
                }
            }
        }

        Console.WriteLine("\n===== HIGHEST GRADE =====");
        Console.WriteLine("\nTop Student: " + topStudent);
        Console.WriteLine("\nHighest Grade: " + highestGrade);

    }
}