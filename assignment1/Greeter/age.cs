using System;

class Age
{
    static void yourAge(string[] args)
    {
        string fullName = "Anupa Baral";
        Console.WriteLine("hello !"+fullName);
        Console.WriteLine("Please enter your date of birth (YYYY-MM-DD):");
        DateTime dob;
        while (!DateTime.TryParse(Console.ReadLine(), out dob))
        {
            Console.WriteLine("Invalid date format. Please enter your date of birth in YYYY-MM-DD format:");
        }
        DateTime currentDate = DateTime.Now;

        int ageYears = currentDate.Year - dob.Year;
        int ageMonths = currentDate.Month - dob.Month;
        int ageDays = currentDate.Day - dob.Day;

        if (ageMonths < 0 || (ageMonths == 0 && ageDays < 0))
        {
            ageYears--;
            ageMonths += 12;
        }

        Console.WriteLine($"Your age is: {ageYears} years, {ageMonths} months, and {ageDays} days.");
    }
}
