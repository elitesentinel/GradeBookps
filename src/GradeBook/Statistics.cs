namespace GradeBook;

public class Statistics
{
    public double Average
    {
        get
        {
            return Sum / Count;
        }
    }
    public double High;
    public double Low;
    public char Letter
    {
        get
        {
            return Average switch
            {
                var d when d >= 90 => 'A',
                var d when d >= 80 => 'B',
                var d when d >= 70 => 'C',
                var d when d >= 60 => 'D',
                _ => 'F',
            };
        }
    }
    public double Sum;
    public int Count;

    public void Add(double number)
    {
        Sum += number;
        Count += 1;
        Low = Math.Min(number, Low);
        High = Math.Max(number, High);
    }

    public Statistics()
    {
        High = double.MinValue;
        Low = double.MaxValue;
        Sum = 0.0;
        Count = 0;
    }
}