namespace Classwork;

public class PracticeTask
{
    public delegate bool isPair(int number);
    public delegate int square(int number);
    
    public static bool pair(int number) => number % 2 == 0;
    public static int numSquare(int number) => number * number;

    public static Func<int, int> cube(int number)
    {
        return delegate(int number)
        {
            return number * number * number;
        };
    }
    
    private static bool isLeepYear(int year) => year % 4 == 0 && year % 100 != 0;

    public static Func<int, int, int, bool> itDay(int year, int month, int day)
    {
        return delegate(int year, int monthOfYear, int dayOfMonth)
        {
            if (monthOfYear != 9)
            {
                return false;
            }

            if (isLeepYear(year))
            {
                return dayOfMonth == 13;
            }

            return dayOfMonth == 12;
        };
    }

    public static Func<int[], int> findMaxInArray(int[] array)
    {
        return delegate(int[] array)
        {
            return array.Max();
        };
    }
    
    public static Func<int[], int> findMinInArray(int[] array)
    {
        return delegate(int[] array)
        {
            return array.Min();
        };
    }

    public static Func<int[], int[]> oddNumbers(int[] array)
    {
        return delegate(int[] array)
        {
            return array.Where(n => n % 2 != 0).ToArray();
        };
    }
}
