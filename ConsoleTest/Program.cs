using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
			CourseDatabase CourseData = new CourseDatabase();
            Console.WriteLine("Hello World!");
        }
    }

	public class UserDatabase
	{
		Dictionary<string, (string, string, string, string, string, string, string[])> uDatabase = new Dictionary<string, (string, string, string, string, string, string, string[])>();
		public UserDatabase()
		{
			Console.WriteLine("Enter location of UserDatabase input file:");
			string loc = Console.ReadLine();
			string line;
			System.IO.StreamReader file = new System.IO.StreamReader(@loc);
			while ((line = file.ReadLine()) != null)
			{
				System.Console.WriteLine(line);
			}
			file.Close();

		}
	}

	public class Account
	{
		private string userName, password;
		private string status;
		private string fName, mName, lName;


	}

	public class CourseDatabase
	{
		public CourseDatabase()                             //This is the constructor for creating the database of courses
		{ 
			Console.WriteLine("Enter location of CourseDatabase input file:");
			string loc = Console.ReadLine();
			string line;
			System.IO.StreamReader file = new System.IO.StreamReader(@loc);
			while ((line = file.ReadLine()) != null)
			{
				System.Console.WriteLine(line);
			}
			file.Close();

		}
	}

	public class Course
	{
		private string courseName, courseTitle, instructor;
		private int totatSeats, availableSeats;
		private float Credits;
	}


	class RegistrationSystem
	{
		private bool isUserAuthenticated;
		private string curAccUsername;
	}


}

