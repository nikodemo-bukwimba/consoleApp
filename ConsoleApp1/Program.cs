// See https://aka.ms/new-console-template for more information

//Empty date time: DateTime dt = new DateTime();

using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dob = new DateTime();
        Console.WriteLine(dob);

        //Create a datetime from date and time
        DateTime dob2 = new DateTime(2000, 5, 25);
        Console.WriteLine(dob2);
        DateTime dob3 = new DateTime(2000, 5, 25, 15, 30, 10);
        Console.WriteLine(dob3);

        //Current time
        Console.WriteLine(DateTime.Now);

        //current date from user string - Tell user about format
        Console.WriteLine("*******current date from user input********");
        var date = DateTime.Parse("January 8 2022 02:20PM");
        Console.WriteLine(date);

        //format the date d.ToString("dd/MM/YYYY")
        Console.WriteLine(date.ToString("ddd d MMM yyyy"));

        //addung to a date 
        var date2 = DateTime.Now;
        date2 = date2.AddDays(2);
        Console.WriteLine(date2);

        //UTC
        Console.WriteLine("******Coordinated Universal Time******");
        var utc = DateTime.UtcNow;
        Console.WriteLine(utc);

        //Display timezone Info
        Console.WriteLine(TimeZoneInfo.Local.GetUtcOffset(utc));
        Console.WriteLine(DateTime.Parse(utc.ToString()));
        //convert utc to local time
        Console.WriteLine(utc.ToLocalTime());

        //Date only
        var dateOnly = new DateOnly(1999, 5, 1);
        Console.WriteLine(dateOnly);
        Console.WriteLine(DateOnly.FromDateTime(utc));

        //time only
        var timeOnly = new TimeOnly(11, 25);
        Console.WriteLine(timeOnly);
        Console.WriteLine($"{timeOnly:hh-mm-tt}");
        int salary = 100000;
        Console.WriteLine($"{salary:c}");
        Console.WriteLine($"{salary.ToString("c")}");

        //Data & time comparison
        var now = DateTime.Now;
        var tommorow = now.AddDays(1);
        var yesterday = now.AddDays(-1);

        Console.WriteLine(now);
        Console.WriteLine(tommorow);
        Console.WriteLine(yesterday);

        Console.WriteLine(now > tommorow);
        Console.WriteLine(now > yesterday);

        // //parse date input from user
        // var userDob = new DateOnly();
        // System.Console.WriteLine("prease enter your date of birth");
        // userDob = DateOnly.ParseExact(Console.ReadLine(),"yyyy/mm/dd");

        // Console.WriteLine(userDob);

        //anatomy - (syntax)
        string GetInfo(string name)
        {
            return $"My name is {name}";
        }
        Console.WriteLine(GetInfo("nikodemo"));
        Console.WriteLine(GetInfo("Mwl.luhondo"));

        //Arrays in c#endregion
        System.Console.WriteLine("****** Array & lists *******");
        int [] marks = [2 , 6,44,];
        string[] names =new string[3];

        for (int i = 0; i< marks.Length;i++)
            names[i] = Console.ReadLine();

        
    }    
}