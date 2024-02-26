using System;
class DOB
{
    static void dateOfBirth()
    {
        string fullName = "Anupa Baral";
        Console.WriteLine("hello !"+fullName);
        Console.WriteLine("Please enter your date of birth (MM/DD/YYYY):");
        string dobString = Console.ReadLine();
        DateTime dob;
        if (DateTime.TryParse(dobString, out dob))
        {
            string birthDateString = dob.ToString("MM/dd/yyyy");
            Console.WriteLine($"Your date of birth is: {birthDateString}");
        }
        else
        {
            Console.WriteLine("Invalid date format entered.");
        }
    }
}

