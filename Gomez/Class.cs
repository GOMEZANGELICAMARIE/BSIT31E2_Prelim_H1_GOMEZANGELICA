using System;

class Class
{
    private string name;
    private List<int> Grades;

    public Class(string name, List<int> grades)
    {
        this.name = name;
        this.Grades = grades;
    }

    public string GetName()
    {
        return name;
    }

    public List<int> GetGrades()
    {
        return Grades;
    }
    public double getAverage()
    {
        return (Grades[0] + Grades[1] + Grades[2]) / 3.0;
    }
}