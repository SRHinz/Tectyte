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
			UserDatabase UserData = new UserDatabase();
            Console.WriteLine("Hello World!");
        }
    }

	public class UserDatabase
	{
		Dictionary<(string, string), Account> uDatabase = new Dictionary<(string, string), Account>();
		public UserDatabase()
		{
			Console.WriteLine("Enter location of UserDatabase input file:");
			string loc = Console.ReadLine();
			string line;
			System.IO.StreamReader file = new System.IO.StreamReader(@loc);
			while ((line = file.ReadLine()) != null)
			{
				string[] words = line.Split(' ');
				uDatabase.Add((words[0], words[1]), new Account(words));

			}
			file.Close();

		}
	}

	public class Account
	{
		private string userName, password;
		private string status;
		private string fName, mName, lName;

		public Account(string[] args)
        {
			UserName = args[0];
			Password = args[1];
			FName = args[2];
			MName = args[3];
			LName = args[4];
			Status = args[5];

			
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Status { get => status; set => status = value; }
        public string FName { get => fName; set => fName = value; }
        public string MName { get => mName; set => mName = value; }
        public string LName { get => lName; set => lName = value; }
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

