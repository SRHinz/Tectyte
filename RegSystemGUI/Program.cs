using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using System.Threading;
using System.ComponentModel;
using System.Drawing.Text;

namespace RegSystemGUI
{
    public static class Program
    {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 
		
        [STAThread]
        static void Main()
        {
			
			RegistrationSystem COE = new RegistrationSystem();
			

			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Form[] forms = new Form[10];
			forms[0] = new Login(ref COE);
			Login login = new Login(ref COE);
			Application.Run(login);
        }

		public class RegistrationSystem
        {
			private (string, string) curAcc;
			private string curTerm = "F14";
			public UserDatabase uData = new UserDatabase();
			public CourseDatabase cData = new CourseDatabase();
			public viewCourses vCourse = new viewCourses();

            public (string, string) CurAcc { get => curAcc; set => curAcc = value; }


        }

		private class HistoryDatabase
		{
			private Dictionary<string, string[]> hisDatabase = new Dictionary<string, string[]>();
			public Dictionary<string, string[]> HisDatabase { get => hisDatabase; }

			public HistoryDatabase()
			{
				int[] hCounter = {10, 2, 23 };
				string loc = Path.GetFullPath("historyDB.in");
				string line;                                                        //We are just going to build a list with the student's course histories that can be added to. 
				string key;
				int numCourses = 0;
				System.IO.StreamReader file2 = new System.IO.StreamReader(@loc);
				while ((line = file2.ReadLine()) != null)
				{
					key = line.Substring(0, 10).TrimEnd();
					numCourses = Convert.ToInt32(line.Substring(11, 2).TrimEnd());  //Converting the number of courses to int32 from the string.
					string[] courses = new string[numCourses];
					int a = 14;
					for (int i = 1; i <= numCourses; i++)
                    {
						if (i == numCourses)
						{
							courses[i-1] = line.Substring(a, line.Length - a);
						}
						else
						{
							courses[i - 1] = line.Substring(a, 23).TrimEnd();
							a += 24;
						}
                    }
					hisDatabase.Add(key, courses);
				}
				file2.Close();
			}
        }

		public class UserDatabase
		{
			private Dictionary<(string, string), Account> uDatabase = new Dictionary<(string, string), Account>(); //Dictionary of Accounts, with username password tuple as the key
			private HistoryDatabase hDatabase = new HistoryDatabase();

            public Dictionary<(string, string), Account> UDatabase { get => uDatabase; }

            public UserDatabase()
			{
				int[] dataBasecounter = { 10, 10, 15, 15, 15, 10 };
				string loc = Path.GetFullPath("userDB.in");
				string line;
				System.IO.StreamReader file = new System.IO.StreamReader(@loc);
				while ((line = file.ReadLine()) != null)
				{
					string[] words = new string[6];
					int a = 0;
					for (int i = 0; i <= 5; i += 1)
					{
						string subString = "";
						if (i != 5)                 //This if else statement handles the status portion of the input line, so that an out of range exception is not thrown for the SubString
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
					if ((words[5] != "faculty") | (words[5] != "admin"))
					{
						try
						{
							UDatabase.Add((words[0], words[1]), new StudentAcc(words, hDatabase.HisDatabase[words[0]]));
						}
						catch (KeyNotFoundException e)              //If there exists no course records for the student, then it will simply create a student account with no coures in their history.
						{
							string[] noHis = { };
							UDatabase.Add((words[0], words[1]), new StudentAcc(words, noHis));
						}
						//So this obsencely annoying looking piece of code should create a student account with the relevant course history. 
					}
					else
					{
						UDatabase.Add((words[0], words[1]), new Account(words));
					}
				}
				file.Close();

			}
			public void viewDatabase()
			{
				Console.WriteLine("User Database");
				foreach (KeyValuePair<(string, string), Account> user in UDatabase)
				{
					Console.WriteLine("Key: {0}, Value: {1}", user.Key, user.Value.getAccount());
				}
			}

			public string authenticateUser(string userName, string Password)
			{
				if (UDatabase.ContainsKey((userName, Password)))
				{
					if (!(UDatabase[(userName, Password)].Status.Equals("faculty") | UDatabase[(userName, Password)].Status.Equals("admin"))) //If the username password tuple exists as a key in the dictionary, and its status is not faculty or admin, then that neccesitates that it is a student account.
					{
						return "student";
					}
					else
					{
						return UDatabase[(userName, Password)].Status;
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
			private string fName;
			private string mName;
			private string lName;
			public string Status { get => status; }
			public string UserName { get => userName; }
			public string Password { get => password; }
            public string FName { get => fName; }
            public string MName { get => mName; }
            public string LName { get => lName; }

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
				return (UserName + ' ' + Password + ' ' + FName + ' ' + MName + ' ' + LName + ' ' + Status);
			}

		}

		public class sHistory: IComparable<sHistory>
		{
			private string course;
			private string term;
			private float credits;
			private string grade;

			public sHistory(string co, string t, float c, string g)
			{
				course = co;
				term = t;
				credits = c;
				grade = g;
			}

			public string Course { get => course; }
			public string Term { get => term; }
			public float Credits { get => credits; }
			public string Grade { get => grade; set => grade = value; }

            public int CompareTo(sHistory other)
            {
                throw new NotImplementedException();
            }
        }


		public class StudentAcc : Account
        {
			
			private List<sHistory> cHistory = new List<sHistory>();     //A list of sHistory classes makes it mutable while also allowing

            public List<sHistory> CHistory { get => cHistory; }

            public StudentAcc(string[] args, string[] courseHistory) : base (args)	//This Student account is a subclass of account, and takes in all the same parameters, plus some for the course history
            {	

				foreach (string s in courseHistory)
                {
					string course = s.Substring(0, 11);
					string term = s.Substring(11, 3);
					float credits = Convert.ToSingle(s.Substring(14, 4));
					string grade = s.Substring(20, s.Length - 20);
					cHistory.Add(new sHistory(course, term, credits, grade));
                }
            }
			
			public void addCourse(string course, string term, float credits, string grade)
            {
				cHistory.Add(new sHistory(course, term, credits, grade));
            }

			public void delCourse(string courseName)
            {
				bool courseFound = false;
				foreach (sHistory c in cHistory)                    //This loop checks each course to see if it is the one that is to be removed. If it is, it will remove it. Only courses that are being taken currently or registered for next semester should be allowed to be deleted.		
				{
					if (c.Course == "courseName" & c.Grade == "N" & !courseFound)
					{ 
						cHistory.Remove(c);
						courseFound = true;
					}
                }
				if (!courseFound)									//If the course does not exist in the student's history, then it will throw an error.
                {
					throw new ArgumentException("That course does not exist in student's history.", courseName);
				}
				
				
            }

            
        }

		public class CourseDatabase
		{
			private Dictionary<string, Course> cDatabase = new Dictionary<string, Course>(); //Creating the dictionary in which we will store the courses 
			public CourseDatabase()                             //This is the constructor for creating the database of courses
			{
				int[] courseCounter = { 10, 15, 10, 4, 3, 1, 5, 5, 5, 5, 5};
				//Console.WriteLine("Enter location of CourseDatabase input file:");
				string loc = Path.GetFullPath("courseDB.in");
				string line;
				System.IO.StreamReader file = new System.IO.StreamReader(@loc);
				while ((line = file.ReadLine()) != null)
				{
					int nblocks = 0;
					nblocks = Convert.ToInt32(Char.GetNumericValue(line[47])); //This will tell how many time blocks the course has
					string[] courseInfo = new string[6 + nblocks];
					int a = 0;
					for (int i = 0; i <= 6 + nblocks - 1; i += 1)
					{
						string subString = "";
						if (i != 6 + nblocks - 1)                 //This if else statement handles everything before the last portion of the line, so to prevent an indexoutofRange exception from being thrown.
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

			public Dictionary<string, Course> CDatabase { get => cDatabase; }   //Made the dictionary a property for easier outside viewing.
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
			private int timeBlock4;
			private int timeBlock5;
			public string CourseTitle { get => courseTitle; }
			public string Instructor { get => instructor; }
			public int TotalSeats { get => totalSeats; }
			public int AvailableSeats { get => availableSeats; set => availableSeats = value; }
			public float Credits { get => credits; }
			public int NtimeBlocks { get => ntimeBlocks; }
			public int TimeBlock1 { get => timeBlock1; }
			public int TimeBlock2 { get => timeBlock2; }
			public int TimeBlock3 { get => timeBlock3; }
            public int TimeBlock4 { get => timeBlock4; }
            public int TimeBlock5 { get => timeBlock5; }

            public Course(string[] args)
			{
				courseTitle = args[0];
				instructor = args[1];
				totalSeats = Convert.ToInt32(args[3]);
				availableSeats = Convert.ToInt32(args[3]);
				credits = Convert.ToSingle(args[2]);
				ntimeBlocks = Convert.ToInt32(args[4]);
				timeBlock1 = Convert.ToInt32(args[5]);
				timeBlock2 = 00000;
				timeBlock3 = 00000;
				timeBlock4 = 00000;
				timeBlock5 = 00000;
				if (ntimeBlocks >= 2)
				{
					timeBlock2 = Convert.ToInt32(args[6]); //If there are 2 time blocks, this allows the placing of it in time block 2
				}
				if (ntimeBlocks >= 3)
				{
					timeBlock3 = Convert.ToInt32(args[7]); //If there are 3 time blocks, this allows the placing of the third one in time block 3
				}
				if (ntimeBlocks >=4 )
                {
					timeBlock4 = Convert.ToInt32(args[8]);
                }
				if (ntimeBlocks == 5)
                {
					timeBlock5 = Convert.ToInt32(args[9]);
                }
			}
		}

		public class viewCourses
		{
			public void displayStuHist(StudentAcc acc, DataGridView output)
            {
				foreach (sHistory course in acc.CHistory)
                {

                }

            }
			public void displayCourses(CourseDatabase cData, DataGridView output)
			{
				int counter = 0;
				foreach (KeyValuePair<string, Course> course in cData.CDatabase)
				{
					string cTitle = course.Value.CourseTitle;
					string instruc = course.Value.Instructor;
					int totS = course.Value.TotalSeats;
					int avS = course.Value.AvailableSeats;
					float cred = course.Value.Credits;
					int nBlocks = course.Value.NtimeBlocks;
					string tBlock1 = solveTimeblock(course.Value.TimeBlock1);
					string tBlock2 = solveTimeblock(course.Value.TimeBlock2);
					string tBlock3 = solveTimeblock(course.Value.TimeBlock3);
					string tBlock4 = solveTimeblock(course.Value.TimeBlock4);
					string tBlock5 = solveTimeblock(course.Value.TimeBlock5);
					if (course.Value.TimeBlock2 == 00000)           //This phrase is what occurs if there is no 
					{
						tBlock2 = "Not Offered";
						tBlock3 = "Not Offered";
						tBlock4 = "Not Offered";
						tBlock5 = "Not Offered";
					}
					else if (course.Value.TimeBlock3 == 00000)
					{
						tBlock3 = "Not Offered";
						tBlock4 = "Not Offered";
						tBlock5 = "Not Offered";
					}
					else if (course.Value.TimeBlock4 == 00000)
                    {
						tBlock4 = "Not Offered";
						tBlock5 = "Not Offered";
					}
					else if (course.Value.TimeBlock5 == 00000)
                    {
						tBlock5 = "Not Offered";
                    }

					output.Rows.Add(course.Key, cTitle, instruc, totS, avS, cred, tBlock1, tBlock2, tBlock3, tBlock4, tBlock5);
					output.Rows[counter].ReadOnly = true;
					counter++;

				}

			}

			private string solveTimeblock(int tB)
			{
				string days = "";
				string time = "";
				int dd = tB / 1000;
				int tt = (tB / 10) % 100;
				int l = tB % 10;
				if (dd - 16 >= 0)                       //Begin day decoding section
				{
					dd += -16;
					days = days.Insert(0, " Fri");
				}
				if (dd - 8 >= 0)
				{
					dd += -8;
					days = days.Insert(0, " Thurs");
				}
				if (dd - 4 >= 0)
				{
					dd += -4;
					days = days.Insert(0, " Weds");
				}
				if (dd - 2 >= 0)
				{
					dd += -2;
					if (dd == 0)
					{
						days = days.Insert(0, "Tues");
					}
					else
					{
						days = days.Insert(0, " Tues");
					}
				}
				if (dd - 1 == 0)
				{
					days = days.Insert(0, "Mon");
				}

				float mTime = tt / 2;                   //This makes tt into military time
				string startT = convertTime(mTime);
				mTime = Convert.ToSingle(mTime + 0.5 * l);  //This gets the ending time in military time, by adding the length times half hour increments to the starting time
				string endT = convertTime(mTime);
				time = (startT + " to " + endT);



				return (days + ", " + time);
			}

			private string convertTime(float mTime)
			{
				string time = "";
				float cTime = mTime % 12;               //This extracts what time it would be on a typical 12 hour clock, absent of AM or PM
				int hour = Convert.ToInt32(cTime - (cTime % 1));        //This gets the hour
				if (hour == 0)
				{
					hour = 12;
				}
				int min = Convert.ToInt32((cTime % 1) * 60);            //This gets the minutes
				time = time.Insert(0, hour + ":" + min);                //This adds the extra 0 for proper reading if the minutes equal 0.
				if (min == 0)
				{
					time = time + "0";
				}
				if (mTime >= 12)
				{
					time = time + "PM";
				}
				else
				{
					time = time + "AM";
				}

				return time;
			}
		}
	}
}
