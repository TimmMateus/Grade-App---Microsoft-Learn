int gradedAssignments = 5;
Student[] students= {
    new Student("Sophia", [90, 86, 87, 98, 100, 94, 90]),
    new Student("Andrew", [92, 89, 81, 96, 90, 89]),
    new Student("Emma", [90, 85, 87, 98, 68, 89, 89, 89]),
    new Student("Logan", [90, 95, 87, 88, 96, 96])
};

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");
foreach (Student student in students)
{
    GradeCalculation.calculateScore(student, gradedAssignments);
    student.printStudent();
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
