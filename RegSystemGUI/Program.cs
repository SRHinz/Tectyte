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
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;

namespace RegSystemGUI
{
	public class Program
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
			RegisterHistoryClasses(ref COE.cData, ref COE.uData);
			Login login = new Login(ref COE);
			Application.Run(login);
		}

		public class RegistrationSystem
		{
			private string curAcc;
			private string curTerm = "F14";
			private string nexTerm = "S15";
			public CourseDatabase cData = new CourseDatabase();
			public UserDatabase uData = new UserDatabase();
			public viewCourses vCourse = new viewCourses();
			public Register registerC;

			public string CurAcc { get => curAcc; set => curAcc = value; }
			public string CurTerm { get => curTerm; }
			public string NexTerm { get => nexTerm; }
		}

        public class regConflictException : Exception
        {
            public regConflictException()
            {
            }

            public regConflictException(string message) : base(message)
            {
            }

            public regConflictException(string message, Exception innerException) : base(message, innerException)
            {
            }
        }

        public static void RegisterHistoryClasses(ref CourseDatabase cData, ref UserDatabase uData)
		{
			foreach (KeyValuePair<string, Account> uValues in uData.UDatabase)
			{
				if (uValues.Value is StudentAcc)
				{
					StudentAcc account = (StudentAcc)uValues.Value;
					string[] courses = account.getFutureCourseNames();
					foreach (string course in courses)
					{
						if (course != null)
						{
							cData.CDatabase[course].enrollStudent(uValues.Value.UserName);
						}
					}
				}
			}
		}

		public class Register: viewCourses
        {
			private CourseDatabase cDatabase;
			public Register(ref CourseDatabase courseData)
            {
				cDatabase = courseData;
            }
			public int stuRegister(StudentAcc sAcc, Course regCourse, string coursetitle, string term, bool admin)		//Just adds a course to the student's schedule
            {
				float courseCredCounter = 0;
				int passable = 0;
				if (!admin)
				{
					foreach (sHistory curCourse in sAcc.CHistory)
					{
						if (curCourse.Grade == "N" & curCourse.Term == term)                    //This guarentees we will only be checking against courses that 
						{
							courseCredCounter += curCourse.Credits;
							int cc = curCourse.Course.Trim().Length - 3;
							int bb = coursetitle.Trim().Length - 3;
							if (curCourse.Course.Substring(0, cc) == coursetitle.Substring(0, bb))
							{
								throw new regConflictException("duplicate");
							}
							else if (courseCredCounter >= 5)
							{
								throw new regConflictException("credits");
							}
							else if (cDatabase.CDatabase[coursetitle].AvailableSeats == 0)
							{
								throw new regConflictException("seats");
							}
							string[] timeBlocks1 = new string[regCourse.NtimeBlocks];
							for (int i = 0; i < timeBlocks1.Length; i++)
							{
								timeBlocks1[i] = base.solveTimeblock(regCourse.TimeBlockCollection[i]).Trim();
							}
							int numTblocks = cDatabase.CDatabase[curCourse.Course.Trim()].NtimeBlocks;
							string[] timeBlocks2 = new string[numTblocks];
							for (int j = 0; j < timeBlocks2.Length; j++)
							{
								timeBlocks2[j] = base.solveTimeblock(cDatabase.CDatabase[curCourse.Course.Trim()].TimeBlockCollection[j]).Trim();
							}
							int[] timeBNum = regCourse.TimeBlockCollection;
							int[] timeBNum2 = cDatabase.CDatabase[curCourse.Course.Trim()].TimeBlockCollection;
							if (base.timeConflict(timeBlocks1, timeBNum, timeBlocks2, timeBNum2))
							{
								if ((passable == 2) | (passable == 3))
								{
									passable = 3;
								}
								else
								{
									passable = 1;
								}
							}
						}

					}
					if (courseRepeatConflict(coursetitle, sAcc))
					{
						if ((passable == 1) | (passable == 3))
						{
							passable = 3;
						}
						else
						{
							passable = 2;
						}
					}												//This should check if the course is a repeat course. It doesn't need to be in the loop because it can check through all of the courses in the history on its own.
				}
				sAcc.addCourse(coursetitle, term, regCourse.Credits, "N");
				return passable;									//Passable gives a code that allows us to know if there is an issue, or what the issue is
            }

			

			private bool courseRepeatConflict(string regCourse, StudentAcc student)
            {
				foreach (sHistory prevCourse in student.CHistory)
                {
					if (prevCourse.Grade != "N")
					{
						if (regCourse.Substring(0, regCourse.Length - 2).Equals(prevCourse.Course.Trim().Substring(0, prevCourse.Course.Trim().Length - 2)))
						{
							return true;
						}
					}
                }
				return false;
            }	   //This will catch if a student has previously taken the course
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
							courses[i - 1] = line.Substring(a, line.Length - a).Trim();
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
			private Dictionary<string, Account> uDatabase = new Dictionary<string, Account>(); //Dictionary of Accounts, with username password tuple as the key
			private HistoryDatabase hDatabase = new HistoryDatabase();
			private Dictionary<string, string> leftovers = new Dictionary<string, string>();

            public Dictionary<string, Account> UDatabase { get => uDatabase; }
			

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
					if (words[5] == "faculty")
                    {
						UDatabase.Add(words[0], new FacultyAcc(words));
						try
						{
							foreach (KeyValuePair<string, string> pair in leftovers)
							{
								if (pair.Value == words[0])
								{
									(UDatabase[words[0]] as FacultyAcc).addAdvisee(pair.Key);      //If there have been students that have been added to the database before their advisor has, this will make sure to add them into the faculty's advisee list, then remove them from leftovers.

								}
							}
						}
						catch (InvalidOperationException b)
                        {
							//Do nothing, skipping over this one
                        }
                    }
					else if ((words[5] != "admin"))
					{
						try
						{
							UDatabase.Add(words[0], new StudentAcc(words, hDatabase.HisDatabase[words[0]]));
							if (UDatabase.ContainsKey(words[5]))
                            {
								(UDatabase[words[5]] as FacultyAcc).addAdvisee(words[0]);	//This will add the student as an advisee of whoever is listed in their status, if the account is already created.
                            }
                            else
                            {
								leftovers.Add(words[0], words[5]);																//If the student's advisor has not yet been added to the database, this will store them in the leftovers dictionary, which keeps track of students who are not yet listed in their advisor's advisee list.
                            }
						}
						catch (KeyNotFoundException)              //If there exists no course records for the student, then it will simply create a student account with no coures in their history.
						{
							string[] noHis = { };
							UDatabase.Add(words[0], new StudentAcc(words, noHis));
						}
						//So this obsencely annoying looking piece of code should create a student account with the relevant course history. 
					}
					else
					{
						UDatabase.Add(words[0], new AdminAcc(words));
					}
				}
				file.Close();
			}
			public void viewDatabase()
			{
				Console.WriteLine("User Database");
				foreach (KeyValuePair<string, Account> user in UDatabase)
				{
					Console.WriteLine("Key: {0}, Value: {1}", user.Key, user.Value.getAccount());
				}
			}

			public string authenticateUser(string userName, string Password)
			{
				if (UDatabase.ContainsKey(userName))
				{
					if (UDatabase[userName].Password == Password)
					{
						if (!(UDatabase[userName].Status.Equals("faculty") | UDatabase[userName].Status.Equals("admin"))) //If the username password tuple exists as a key in the dictionary, and its status is not faculty or admin, then that neccesitates that it is a student account.
						{
							return "student";
						}
						else
						{
							return UDatabase[userName].Status;
						}
					}
                    else
                    {
						return "Failed";
                    }
				}
				else
				{
					return "Failed";
				}
			}

			public void RemoveUser(ref CourseDatabase cData, Account user, string nTerm)
            {
				if (user is StudentAcc)
                {
					StudentAcc stuUser = user as StudentAcc;
					foreach (sHistory c in stuUser.CHistory)
                    {
						if (c.Grade == "N" & c.Term == nTerm)
                        {
							cData.CDatabase[c.Course.Trim()].unenrollStudent(stuUser.UserName);					//Unenrolls the student from all courses they were registered for next semester
                        }
                    }
					(uDatabase[stuUser.Status.Trim()] as FacultyAcc).removeAdvisee(stuUser.UserName);			//Removes the student from their advisor's advisee list
					uDatabase.Remove(stuUser.UserName);															//Removes the student and their login information from the system
					//Student removal code
                }
				else if (user is FacultyAcc)
                {
					FacultyAcc facUser = user as FacultyAcc;
					foreach (KeyValuePair<string, Course> C in cData.CDatabase)
                    {
						if (C.Value.Instructor == facUser.UserName)
                        {
							C.Value.changeInstructor("Staff");													//This will change any courses that the faculty is teaching to have "staff" as the instructor
                        }
                    }
					foreach (KeyValuePair<string, Account> Acc in uDatabase)
					{
						if (Acc.Value.Status == facUser.UserName)													
                        {
							Acc.Value.Status = "Staff";															//Checks through all accounts with a status equal to the faculty's username, which means the only matches should be the student accounts with this faculty as their advisor
                        }
					}
					uDatabase.Remove(facUser.UserName);															//Removes the faculty from the system
					//Faculty Removal Code
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
			public string Status { get => status; set => status = value; }
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
				status = args[5].Trim();
			}

			public string getAccount()
			{
				return (UserName + ' ' + Password + ' ' + FName + ' ' + MName + ' ' + LName + ' ' + Status);
			}

		}

		public class sHistory
		{
			private string course;
			private string term;
			private float credits;
			private string grade;

			public sHistory(string co, string t, float c, string g)
			{
				course = co.Trim();
				term = t;
				credits = c;
				grade = g;
			}

			public string Course { get => course; }
			public string Term { get => term; }
			public float Credits { get => credits; }
			public string Grade { get => grade; set => grade = value; }

        }


		public class StudentAcc : Account
        {
			
			private List<sHistory> cHistory = new List<sHistory>();     //A list of sHistory classes makes it mutable while also allowing

            public List<sHistory> CHistory { get => cHistory; }

			private float totalCred = 0;

			public float totalCredits { get => totalCred; }

			private float gradePointAvg = 0;

			public float GPA { get => gradePointAvg; }

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
				float gradePoints = 0;
				Dictionary<string, float> gradesGP = new Dictionary<string, float>()
				{
					{"A", 4.0F },
					{"A-", 3.7F },
					{"B+", 3.3F },
					{"B", 3.0F },
					{"B-", 2.7F },
					{"C+", 2.3F },
					{"C", 2.0F },
					{"C-", 1.7F },
					{"D+", 1.3F },
					{"D", 1.0F },
					{"D-", 0.7F },
					{"F", 0.0F },
					{"WF", 0.0F },

				};
				float credits4GradePoint = 0;
				foreach (sHistory c in cHistory)
                {
					if (c.Term.Trim() != "F14" && c.Term.Trim() != "S15")
                    {
						if (c.Grade.Substring(0, 1) == "R")
                        {
							foreach (sHistory s in cHistory)
                            {
								if ((s.Course.Trim().Substring(0, (s.Course.Trim().Length - 2)) == (c.Course.Trim().Substring(0, (c.Course.Trim().Length - 2 )))) &  (s.Grade.Trim().Substring(0, 1) != "R"))
                                {
									credits4GradePoint -= s.Credits;
									gradePoints -= gradesGP[s.Grade.Trim()];
                                }

							}
                        }
						totalCred += c.Credits;
						credits4GradePoint += c.Credits;
						gradePoints += gradesGP[c.Grade.Trim()];
                    }
						
                }
				gradePointAvg = gradePoints / credits4GradePoint;
            }

			public string[] getFutureCourseNames()
			{
				string[] fCourses = new string[cHistory.Count];
				int count = 0;
				foreach (sHistory his in cHistory)
				{
					if (his.Grade.Trim() == "N" && his.Term.Trim() != "F14")
					{
						fCourses[count] = his.Course.Trim();
					}
					count++;
				}
				return fCourses;
			}

			public void addCourse(string course, string term, float credits, string grade)
            {
				cHistory.Add(new sHistory(course, term, credits, grade));
            }

			public bool delCourse(string courseName)
            {
				bool success = false;
				foreach (sHistory c in cHistory)        //This loop checks each course to see if it is the one that is to be removed. If it is, it will remove it. Only courses that are being taken currently or registered for next semester should be allowed to be deleted.		
				{
					if (c.Course.Trim() == courseName && c.Grade == "N")
					{ 
						cHistory.Remove(c);
						success = true;
						break;
					}
                }
				return success;
				
            }

            
        }

		public class FacultyAcc: Account
        {
			private List<string> advisees = new List<string>();
			private Dictionary<string, Course> teachingCourses = new Dictionary<string, Course>();
			public FacultyAcc(string[] args) : base(args)
            {

            }

            public List<string> Advisees { get => advisees;}

			public void addAdvisee(string stuUser)
            {
				advisees.Add(stuUser);
            }

			public void removeAdvisee(string stuUser)
            {
				advisees.Remove(stuUser);
            }

			
        }

		public class AdminAcc: Account
        {
			public AdminAcc(string[] args): base(args)
            {

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
							subString = line.Substring(a, courseCounter[i]).Trim();
						}
						else
						{
							subString = line.Substring(a, line.Length - a).Trim(); //If it is the last bit of the line, then it simply checks how many characters there are between the end of the line and where it is starting from, and gives that as the length to increment.
						}

						a = a + courseCounter[i] + 1;
						courseInfo[i] = subString.Trim();
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
			private int[] timeBlockCollection;
			private List<string> enrolledStudents = new List<string>();

			public string CourseTitle { get => courseTitle; }
			public string Instructor { get => instructor; }
			public int TotalSeats { get => totalSeats; }
			public int AvailableSeats { get => availableSeats; } 
			public float Credits { get => credits; }
			public int NtimeBlocks { get => ntimeBlocks; }
			public int TimeBlock1 { get => timeBlock1; }
			public int TimeBlock2 { get => timeBlock2; }
			public int TimeBlock3 { get => timeBlock3; }
            public int TimeBlock4 { get => timeBlock4; }
            public int TimeBlock5 { get => timeBlock5; }
            public int[] TimeBlockCollection { get => timeBlockCollection; }

			public List<string> EnrolledStudents { get => enrolledStudents; }




			public Course(string[] args)
			{
				courseTitle = args[0];
				instructor = args[1].Trim();
				totalSeats = Convert.ToInt32(args[3]);
				availableSeats = Convert.ToInt32(args[3]);
				credits = Convert.ToSingle(args[2]);
				ntimeBlocks = Convert.ToInt32(args[4]);
				timeBlockCollection = new int[ntimeBlocks];
				timeBlock1 = Convert.ToInt32(args[5]);
				timeBlockCollection[0] = timeBlock1;
				timeBlock2 = 00000;
				timeBlock3 = 00000;
				timeBlock4 = 00000;
				timeBlock5 = 00000;
				if (ntimeBlocks >= 2)
				{
					timeBlock2 = Convert.ToInt32(args[6]); //If there are 2 time blocks, this allows the placing of it in time block 2
					TimeBlockCollection[1] = timeBlock2;
				}
				if (ntimeBlocks >= 3)
				{
					timeBlock3 = Convert.ToInt32(args[7]); //If there are 3 time blocks, this allows the placing of the third one in time block 3
					timeBlockCollection[2] = timeBlock3;
				}
				if (ntimeBlocks >=4 )
                {
					timeBlock4 = Convert.ToInt32(args[8]);
					timeBlockCollection[3] = timeBlock4;
                }
				if (ntimeBlocks == 5)
                {
					timeBlock5 = Convert.ToInt32(args[9]);
					TimeBlockCollection[4] = timeBlock5;
                }
				
			}

			public void enrollStudent(string student)
            {
				enrolledStudents.Add(student);
				availableSeats--;
            }

			public void unenrollStudent(string student)
            {
				enrolledStudents.Remove(student);
				availableSeats++;
            }

			public void changeInstructor(string newInstructor)
            {
				instructor = newInstructor;
            }

		}

		public class viewCourses
		{
			public void displayStuHist(StudentAcc acc, DataGridView output, string type, string Term, CourseDatabase cData)
            {
				foreach (sHistory course in acc.CHistory)
                {

					if (type == "History")
                    {
						if (course.Grade != "N")
                        {
							output.Rows.Add(course.Course, course.Term, course.Credits, course.Grade);
						}
					}

                    else if (type == "Current")
                    {
						if (course.Grade == "N")
                        {
							if (course.Term == Term)
							{ 
								output.Rows.Add(course.Course, course.Term, course.Credits, course.Grade);
                            }
							

						}

                    }

                    else
                    {
						if (course.Grade == "N")
							if (course.Term != Term)
                            {
								int nBlocks = cData.CDatabase[course.Course.Trim()].NtimeBlocks;
								string tBlock1 = solveTimeblock(cData.CDatabase[course.Course.Trim()].TimeBlock1);
								string tBlock2 = solveTimeblock(cData.CDatabase[course.Course.Trim()].TimeBlock2);
								string tBlock3 = solveTimeblock(cData.CDatabase[course.Course.Trim()].TimeBlock3);
								string tBlock4 = solveTimeblock(cData.CDatabase[course.Course.Trim()].TimeBlock4);
								string tBlock5 = solveTimeblock(cData.CDatabase[course.Course.Trim()].TimeBlock5);
								output.Rows.Add(course.Course, course.Term, course.Credits, course.Grade, tBlock1, tBlock2, tBlock3, tBlock4, tBlock5);
							}
                    }

					
                }

            }
			public bool timeConflict(string[] t1, int[] n1, string[] t2, int[] n2)
			{
				bool conflict = false;
				string issue = "";
				int num1 = 0;                   //These keep track of the position for the int blocks, which have the base 5 digit timeblocks in them
				int num2 = 0;
				List<float> st1 = new List<float>();
				List<float> st2 = new List<float>();
				foreach (int sTime in n1)
				{
					st1.Add((Convert.ToSingle((sTime / 10) % 100) / 2));
				}
				foreach (int sTime in n2)
				{
					st2.Add(Convert.ToSingle(((sTime) / 10) % 100) / 2);
				}
				List<float> lengths1 = new List<float>();
				List<float> lengths2 = new List<float>();
				foreach (int lTime in n2)
				{
					lengths2.Add(Convert.ToSingle((lTime % 10) * .5));
				}
				foreach (int lTime in n1)
				{
					lengths1.Add(Convert.ToSingle((lTime % 10) * .5));
				}
				foreach (string timeblock in t1)                        //This will be checking against every timeblock for the first course being compared
				{
					string[] daysAndTime = timeblock.Split(',');
					string[] days1 = daysAndTime[0].Split(' ');
					num2 = 0;
					foreach (string timeblock2 in t2)                   //This will be making sure every timeblock of the second course is compared
					{
						string[] daysAndTime2 = timeblock2.Split(',');
						string[] days2 = daysAndTime2[0].Split(' ');
						foreach (string i in days1)                     //This makes sure each day is checked in the list of days for timeblock 1
						{
							foreach (string j in days2)                 //THis does the above for all the days in timeblock 2
							{
								if (i == j)                             //If there are matching days, then we get to check those!
								{
									int comp1 = st1[num1].CompareTo(st2[num2]);
									int comp2 = (st1[num1] + lengths1[num1]).CompareTo(st2[num2]);
									int comp3 = st2[num2].CompareTo(st1[num1]);
									int comp4 = (st2[num2] + lengths2[num2]).CompareTo(st1[num1]);

									if (((comp1 <= 0) & (comp2 > 0)) | (comp3 <= 0) & (comp4 > 0))
									{
										conflict = true;
										return conflict;
									}
								}
							}
						}
						num2 += 1;
					}
					num1 += 1;
				}

				return conflict;
			}

			public void displayFacultyCourses(CourseDatabase cData, DataGridView output, string instructor)
            {
				List<string> cFdata = new List<string>();
				foreach (KeyValuePair<string, Course> course in cData.CDatabase)
                {
					if (course.Value.Instructor.Trim() == instructor.Trim())
                    {
						output.Rows.Add(course.Key, course.Value.CourseTitle.Trim(), course.Value.Instructor.Trim(), course.Value.TotalSeats, course.Value.AvailableSeats, course.Value.Credits, course.Value.NtimeBlocks, solveTimeblock(course.Value.TimeBlock1), solveTimeblock(course.Value.TimeBlock2), solveTimeblock(course.Value.TimeBlock3), solveTimeblock(course.Value.TimeBlock4), solveTimeblock(course.Value.TimeBlock5)); //This solves the issue of having to copy over the entire course database and then delete from the copy by simply printing out all the things of courses that match instructor to the current signed in account. 
                    }
                }
            }

			public void displaySearchCourses(CourseDatabase cData, DataGridView output, string c)
            {
				Course course = cData.CDatabase[c];
				string cTitle = course.CourseTitle.Trim();
				string instruc = course.Instructor.Trim();
				int totS = course.TotalSeats;
				int avS = course.AvailableSeats;
				float cred = course.Credits;
				int nBlocks = course.NtimeBlocks;
				string tBlock1 = solveTimeblock(course.TimeBlock1);
				string tBlock2 = solveTimeblock(course.TimeBlock2);
				string tBlock3 = solveTimeblock(course.TimeBlock3);
				string tBlock4 = solveTimeblock(course.TimeBlock4);
				string tBlock5 = solveTimeblock(course.TimeBlock5);
				output.Rows.Add(c, cTitle, instruc, totS, avS, cred, tBlock1, tBlock2, tBlock3, tBlock4, tBlock5);
			}

			public void displayCourses(CourseDatabase cData, DataGridView output)
			{
				int counter = 0;
				foreach (KeyValuePair<string, Course> course in cData.CDatabase)
				{
					string cTitle = course.Value.CourseTitle.Trim();
					string instruc = course.Value.Instructor.Trim();
					int totS = course.Value.TotalSeats;
					int avS = course.Value.AvailableSeats;
					float cred = course.Value.Credits;
					int nBlocks = course.Value.NtimeBlocks;
					string tBlock1 = solveTimeblock(course.Value.TimeBlock1);
					string tBlock2 = solveTimeblock(course.Value.TimeBlock2);
					string tBlock3 = solveTimeblock(course.Value.TimeBlock3);
					string tBlock4 = solveTimeblock(course.Value.TimeBlock4);
					string tBlock5 = solveTimeblock(course.Value.TimeBlock5);
					output.Rows.Add(course.Key, cTitle, instruc, totS, avS, cred, tBlock1, tBlock2, tBlock3, tBlock4, tBlock5);
					output.Rows[counter].ReadOnly = true;
					counter++;

				}

			}

			public string solveTimeblock(int tB)
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

				float mTime = Convert.ToSingle(tt) / 2;                   //This makes tt into military time
				string startT = convertTime(mTime);
				mTime = Convert.ToSingle(mTime + 0.5 * l);  //This gets the ending time in military time, by adding the length times half hour increments to the starting time
				string endT = convertTime(mTime);
				time = (startT + " to " + endT);


				if (tB == 0)
				{
					return ("-");
				}
				else
				{
					return (days + ", " + time);
				}
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
