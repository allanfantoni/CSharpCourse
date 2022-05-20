using OnlineCoursePortal.Entities;

try
{
    HashSet<Student> set = new();

    Console.Write("How many students for course A? ");
    int studentsCourseA = int.Parse(Console.ReadLine());
    AddStudentsToASet(set, studentsCourseA);

    Console.Write("How many students for course B? ");
    int studentsCourseB = int.Parse(Console.ReadLine());
    AddStudentsToASet(set, studentsCourseB);

    Console.Write("How many students for course C? ");
    int studentsCourseC = int.Parse(Console.ReadLine());
    AddStudentsToASet(set, studentsCourseC);

    Console.WriteLine($"Total students: {set.Count}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

static void AddStudentsToASet(HashSet<Student> set, int students)
{
    for (int i = 0; i < students; i++)
        set.Add(new Student { Id = int.Parse(Console.ReadLine()) });
}