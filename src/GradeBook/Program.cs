namespace GradeBook;
class Program
{
    static void Main(String[] args)
    {
        IBook book = new DiskBook("Arslan's Grade Book");

        book.GradeAdded += OnGradeAdded;

        EnterGrades(book);

        var stats = book.GetStatistics();

        Console.WriteLine($"For the book named {book.Name}");
        Console.WriteLine($"Highest grade is: {stats.High}, lowest grade is: {stats.Low}, average grade is: {stats.Average:N1}, letter grade is {stats.Letter}.");
    }


    private static void EnterGrades(IBook book)
    {
        while (true)
        {
            Console.WriteLine("Enter a grade or 'q' to quit.");
            var input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }
            try
            {
                var grade = double.Parse(input);
                book.AddGrade(grade);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("**");
            }

        }
    }

    static void OnGradeAdded(object sender, EventArgs e)
    {
        Console.WriteLine("A grade was added.");

    }
}