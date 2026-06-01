using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Bobby Lee", "Math");
        Console.WriteLine(myAssignment.GetSummary());

        MathAssignment myMathAssignment = new MathAssignment("Bobby Lee", "Math", "7e", "1-1000");
        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());

        WritingAssignment myWritingAssignment = new WritingAssignment("Sean Spencer", "English 101", "How to trick an entire police department into thinking you're a psycic. ");
        Console.WriteLine(myWritingAssignment.GetSummary());
        Console.WriteLine(myWritingAssignment.GetWritingInformation());
    }
}