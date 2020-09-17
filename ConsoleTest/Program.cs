using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Security.Cryptography;

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

	class RegistrationSystem
	{
		private bool isUserAuthenticated;
		private string curAccUsername;
		static void Main(string[] args)
        {
			Console.WriteLine("Please Login");
			string username, password = Console.ReadLine();
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

		public string authenticateUser(string userName, string Password)
        {
			if (uDatabase.ContainsKey((userName, Password)))
			{
				if (!(uDatabase[(userName, Password)].Status.Equals("faculty") | uDatabase[(userName, Password)].Status.Equals("admin"))) //If the username password tuple exists as a key in the dictionary, and its status is not faculty or admin, then that neccesitates that it is a student account.
				{
					return "student";
				}
				else
                {
					return uDatabase[(userName, Password)].Status;
                }
			}
            else
            {
				return "Failed";
            }				
        }

		
	}

	public class Account
	{
		private string userName;
		private string password;
		private string status;
		private string fName { get; }
		private string mName { get; }
		private string lName { get; }
        public string Status { get => status;}
        public string UserName { get => userName;}
        public string Password { get => password;}

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
			return (UserName + ' ' + Password + ' ' + fName + ' ' + mName + ' ' + lName + ' ' + Status);
        }
        
    }

	public class CourseDatabase
	{
		private Dictionary<string, Course> cDatabase = new Dictionary<string, Course>(); //Creating the dictionary in which we will store the courses 
		public CourseDatabase()                             //This is the constructor for creating the database of courses
		{
			int[] courseCounter = { 10, 15, 10, 4, 3, 1, 5, 5, 5 };
			Console.WriteLine("Enter location of CourseDatabase input file:");
			string loc = Console.ReadLine();
			string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@loc);
			while ((line = file.ReadLine()) != null)
			{
				int nblocks = 0;
				nblocks = Convert.ToInt32(Char.GetNumericValue(line[47])); //This will tell how many time blocks the course has
				string[] courseInfo = new string[6+nblocks];
				int a = 0;
				for (int i = 0; i <= 6+nblocks-1; i += 1)
				{
					string subString = "";
					if (i != 6+nblocks-1)                 //This if else statement handles everything before the last portion of the line, so to prevent an indexoutofRange exception from being thrown.
					{
						subString = line.Substring(a, courseCounter[i]).TrimEnd();
					}
					else
					{
						subString = line.Substring(a, line.Length - a); //If it is the last bit of the line, then it simply checks how many characters there are between the end of the line and where it is starting from, and gives that as the length to increment.
					}

					a = a + courseCounter[i] + 1;
					courseInfo[i] = subString;
				}

				CDatabase.Add(courseInfo[0], new Course(courseInfo.Skip(1).ToArray())); //Passes the course info array's first element as the key, and then sends the rest to make a new Course object


			}

			file.Close();

		}

        public Dictionary<string, Course> CDatabase { get => cDatabase; }
    }

	public class Course
	{
		private string courseTitle;
		private string instructor;
		private int totalSeats;
		private int availableSeats; //Available seats will be the only variable that we will want to change after instantiation
		private float credits;
		private int ntimeBlocks;
		private int timeBlock1;
		private int timeBlock2;
		private int timeBlock3;
        public string CourseTitle { get => courseTitle; }
        public string Instructor { get => instructor; }
        public int TotalSeats { get => totalSeats; }
        public int AvailableSeats { get => availableSeats; set => availableSeats = value; }
        public float Credits { get => credits; }
        public int NtimeBlocks { get => ntimeBlocks; }
        public int TimeBlock1 { get => timeBlock1; }
        public int TimeBlock2 { get => timeBlock2; }
        public int TimeBlock3 { get => timeBlock3; }

        public Course(string[] args)
        {
			courseTitle = args[0];
			instructor = args[1];
			totalSeats = Convert.ToInt32(args[2]);
			availableSeats = Convert.ToInt32(args[3]);
			credits = Convert.ToSingle(args[4]);
			ntimeBlocks = Convert.ToInt32(args[5]);
			timeBlock1 = Convert.ToInt32(args[6]);
			if (ntimeBlocks == 2)
            {
				timeBlock2 = Convert.ToInt32(args[7]); //If there are 2 time blocks, this allows the placing of it in time block 2
            }
			if (ntimeBlocks == 3)
			{ 
				timeBlock3 = Convert.ToInt32(args[8]); //If there are 3 time blocks, this allows the placing of the third one in time block 3
			}
		}
	}

	public class viewCourses
    {
		public void displayCourses(CourseDatabase cData)
        {
			foreach (KeyValuePair<string, Course> course in cData.CDatabase)
			{
				string cTitle = course.Value.CourseTitle;
				string instruc = course.Value.Instructor;
				int totS = course.Value.TotalSeats;
				int avS = course.Value.AvailableSeats;
				float cred = course.Value.Credits;

				
			}

        }
    }
}

