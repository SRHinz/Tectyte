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
			//UserDatabase UserData = new UserDatabase();
			CourseDatabase CourseData = new CourseDatabase();
			CourseData.viewDatabase();
			//UserData.viewDatabase();
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
		private Dictionary<string, Course> cDatabase = new Dictionary<string, Course>();
		public CourseDatabase()                             //This is the constructor for creating the database of courses
		{
			int[] stringLengths = { 10, 15, 10, 4, 3, 1, 5, 5 };
			Console.WriteLine("Enter location of CourseDatabase input file:");
			string loc = Console.ReadLine();
			string line;
			System.IO.StreamReader file = new System.IO.StreamReader(@loc);
			while ((line = file.ReadLine()) != null)
			{
				string[] inputs = new string[8];
				int start = 0;
				for (int i = 0; i <= 7; i++)
                {
					string subString = "";
					if (i == 5) // takes care of classes with more than one time block
                    {
						subString = line.Substring(start, stringLengths[i]).TrimEnd();
						if (subString == "1")
						{
							inputs[i] = subString;
							start = start + stringLengths[i] + 1;
							i++;
							subString = line.Substring(start, stringLengths[i]).TrimEnd();
							inputs[i] = subString;
							break;
						}


					}
					else if (i != 7)       //This if else statement handles the status portion of the input line, so that an out of range exception is not thrown for the SubString
					{
						subString = line.Substring(start, stringLengths[i]).TrimEnd();
					}
					else
					{
						subString = line.Substring(start, line.Length - start); //If it is the last bit of the line, then it simply checks how many characters there are between the end of the line and where it is starting from, and gives that as the length to increment.
					}
					inputs[i] = subString;
					start = start + stringLengths[i] + 1;
				}
				cDatabase.Add(inputs[0], new Course(inputs));
			}
			file.Close();

		}
		public void viewDatabase()
        {
			Console.WriteLine("Course Database");
			foreach (KeyValuePair<string, Course> user in cDatabase)
            {
				Console.WriteLine("Key: {0}, Value: {1}", user.Key, user.Value.getCourse());
			}

		}
	}

	public class Course
	{
		private string courseName, courseTitle, instructor;
		private int totalSeats, availableSeats, numTimeBlocks;
		private float Credits;
		string[] timeBlocks = new string[2];

		public Course(string[] args)
        {
			courseName = args[0];
			courseTitle = args[1];
			instructor = args[2];
			Credits = float.Parse(args[3]);
			totalSeats = int.Parse(args[4]);
			numTimeBlocks = int.Parse(args[5]);
			int s = 6;
			for (int i = 0; i < numTimeBlocks; i++, s++)
				timeBlocks[i] = args[s];

			

        }

		public string getCourse()
        {
			return (courseTitle + ' ' + instructor + ' ' + Credits.ToString() + ' ' + totalSeats.ToString() + ' ' + numTimeBlocks.ToString() + ' ' + timeBlocks[0] + ' ' + timeBlocks[1]);
        }
	}


	class RegistrationSystem
	{
		private bool isUserAuthenticated;
		private string curAccUsername;
	}


}

