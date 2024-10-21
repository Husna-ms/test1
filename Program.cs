using System.Text.RegularExpressions;
//prompt the user to input their name and birthdate
Console.Write("Enter your name");
string name= Console.ReadLine();

Console.Write("Enter  your birthday (MM/dd/yyyy": );
string birthdayInput;

Regex dateRegex= new Regex(@"(0[1-9]1[0-2]/0[1\9-][12][0-9]3[01]/\d\d(4)$");


//Validate the birthate format using a regular expression (MM/dd/yyyy). example: if (!Regex.IsMatch(birthdateInput, @"^(0[1-9][1][0-2]/(0[1-9][12][0-9]3[01]^d{4}$))"))
do{
    Console.Write("Enter your birthday(MM/dd/yyyy): ");
    birthdayInput=Console.ReadLine();
if(!dateRegex.IsMatch(birthdayInput))
{
    Console.WriteLine("Invalid date format! please enter in MM//dd/yyyy format.");
}
}while (!dateRegex.IsMatch(birthdayinput));
//calculate and display the user's age based on the birthdate
DateTime birthday = DateTime.Parse(birthdayInput);
int age = DateTime.Now.Year - birthday.Year;
if(DateTime.Now.DayOfYear < birthday.dayofyear)
{
    age--;
}

//save the user's information to a file named "user_info.txt"
string filePath = "user_info.txt";
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            sw.WriteLine($"Name: {name}");
            sw.WriteLine($"Age: {age}");
        }

        Console.WriteLine("\nUser information saved to 'user_info.txt'.");
//read and display the contents of the "user_info.txt" file
   Console.WriteLine("\nReading contents of 'user_info.txt':");
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
//prompt the user to enter a directory path
Console.Write("\nEnter a directory path: ");
        string directoryPath = Console.ReadLine();
        if (Directory.Exists(directoryPath))
        {
            Console.WriteLine("\nFiles in the directory:");
            string[] files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
        else
        {
            Console.WriteLine("Directory does not exist.");
        }
//list all files within the specified directory

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string directoryPath = "your_directory_path_here";
        string[] files = Directory.GetFiles(directoryPath);
        foreach (string file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }
    }
}
//prompt the user to input a string
Console.Write("\nEnter a string to format to title case: ");
        string inputString = Console.ReadLine();
        
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;        
        string titleCaseString = textInfo.ToTitleCase(inputString.ToLower());

        Console.WriteLine($"\nFormatted string in title case: {titleCaseString}");
//format the string to title case
//explicity trigger garbage collection
  Console.WriteLine("\nTriggering garbage collection...");
        GC.Collect(); // Force the garbage collector to run
        GC.WaitForPendingFinalizers(); // Ensures that all finalizers have completed before proceeding

        Console.WriteLine("Garbage collection completed."); 

        Console.WriteLine("\npress any key to exit...");
        Console.ReadKey();
        }
        static internal CalculateAge(DateTime birthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;
            
        }