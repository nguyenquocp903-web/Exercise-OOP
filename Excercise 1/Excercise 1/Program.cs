using System;
using System.ComponentModel.Design;

public class Student
{
    private string name;
    private double score;
    private static int totalStudents = 0;

    public Student(string name, double score)
    {
        this.name = name;
        this.score = score;
        totalStudents++;
    }

   
    public string GetName()
    {
        return "Name : " + name;


    }


    public double GetScore()
    {
        return  score;

    }

    public bool Ispassed()
    {
        if (score >= 5) return true;
        else
            return false;

    }
    public string GetClassification()
    {
        if (score >= 8) return "Exellent";
        else if (score >= 6) return "Good";
        else if (score >= 5) return "Average";
       else
            return "weak";
    }

    static int GetTotalStudent()
    {
        return totalStudents;


    }
    public static Student FindTopStudent(Student[] students)
    {

        Student top = students[0];
        for(int i=1;i < students.Length; i++)
        {

            if (students[i].GetScore()>top.GetScore())
            {
                top = students[i];

            }
        }
        return top;
            
                
                
                }
    public static double CalculateAverageScore(Student[] students)
    {
     

        double sum = 0;
        foreach (Student s in students)
        {
            sum += s.GetScore();
        }
        return sum / students.Length;
    }

    class Program
    {


        public static void Main(string[] args)
        {
           
            Student[] students = new Student[]
            {
            new Student("ty", 8.5),
            new Student("teo", 6.7),
            new Student("tun", 3),
            new Student("bom", 7.1),
            new Student("dan", 5.4)
            };
                     
            Console.WriteLine($"Total students create: {Student.GetTotalStudent()}");
            Console.WriteLine();
            Console.WriteLine("Student List:");
            foreach (Student s in students)
            {
                string status = s.Ispassed() ? "Passed" : "Failed";
                Console.WriteLine($"{s.GetName()}: Score = {s.GetScore()}, + Classification = {s.GetClassification()}, Status = {status}");
            }
            Console.WriteLine();

            
            Student top = Student.FindTopStudent(students);
            Console.WriteLine($"Top student: {top.GetName()} with score {top.GetScore()}");
            Console.WriteLine();

        
            double avg = Student.CalculateAverageScore(students);
            Console.WriteLine($"Class average score: {avg}");
        }
    }
}


