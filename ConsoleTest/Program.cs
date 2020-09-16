using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
			//CourseDatabase CourseData = new CourseDatabase();
			UserDatabase UserData = new UserDatabase();
			UserData.viewDatabase();
            Console.WriteLine("Hello World!");
        }
    }

	public class UserDatabase
	{
		private Dictionary<(string, string), Account> uDatabase = new Dictionary<(string, string), Account>(); //Dictionary of Accounts, with username password tuple as the key
		public UserDatabase()
		{
			int[] dataBasecounter = {10, 10, 15, 15, 15, 10};
			Console.WriteLine("Enter location of UserDatabase input file:");
			string loc = Console.ReadLine();
			string line;
			System.IO.StreamReader file = new System.IO.StreamReader(@loc);
			while ((line = file.ReadLine()) != null)
			{
				string[] words = new string[6];
				int a = 0;
				for (int i = 0; i <= 5; i+=1)
                {
					string subString = "";
					if (i!=5)					//This if else statement handles the status portion of the input line, so that an out of range exception is not thrown for the SubString
					{
						subString = line.Substring(a, dataBasecounter[i]).TrimEnd(); 
					}
					else
                    {
						subString = line.Substring(a, line.Length - a); //If it is the last bit of the line, then it simply checks how many characters there are between the end of the line and where it is starting from, and gives that as the length to increment.
                    }
					
					a = a + dataBasecounter[i] + 1;
					words[i] = subString;
                }
				uDatabase.Add((words[0], words[1]), new Account(words));

			}
			file.Close();
		}
		public void viewDatabase()
        {
			Console.WriteLine("User Database");
			foreach (KeyValuePair<(string, string), Account> user in uDatabase)
            {
				Console.WriteLine("Key: {0}, Value: {1}", user.Key, user.Value.getAccount());
            }
        }

		
	}

	public class Account
	{
		private string userName { get; set; }
		private string password { get; set; }
		private string status { get; set; }
		private string fName { get; set; }
		private string mName { get; set; }
		private string lName { get; set; }

		public Account(string[] args)
        {
			userName = args[0];
			password = args[1];
			fName = args[2];
			mName = args[3];
			lName = args[4];
			status = args[5];
        }

		public string getAccount()
        {
			return (userName + ' ' + password + ' ' + fName + ' ' + mName + ' ' + lName + ' ' + status);
        }
        
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

