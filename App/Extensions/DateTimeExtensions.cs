namespace App.Extensions;

public static class DateTimeExtensions
{
    public static DateTime AddWeeks(this DateTime dateTime, int numberOfWeeks)
    {
        return dateTime.AddDays(numberOfWeeks * 7);
    }
    
    public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
    {
        var diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
        return dt.AddDays(-1 * diff).Date;
    }

    public static List<DateTime> GetWeeks(this DateTime month, DayOfWeek startOfWeek)
    {
        var firstOfMonth = new DateTime(month.Year, month.Month, 1);
        var daysToAdd = ((int) startOfWeek + 6 - (int) month.DayOfWeek) % 7;
        var firstStartOfWeek = firstOfMonth.AddDays(daysToAdd);

        var current = firstStartOfWeek;
        var weeks = new List<DateTime>();
        while (current.Month == month.Month)
        {
            weeks.Add(current);
            current = current.AddDays(7);
        }

        return weeks;
    }
}