namespace GradeBook;
class Program
{
    static void Main(String[] args)
    {
        var book = new Book("Arslan's Grade Book");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);

        var stats = book.GetStatistics();
        Console.WriteLine($"Highest grade is: {stats.High}, lowest grade is: {stats.Low}, average grade is: {stats.Average}");
    }
}


