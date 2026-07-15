namespace SessionOne
{
    internal class Program
    {
        //Entery Point
        /*
         * Hello This mulitple Line
         */
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Comment_Demo();
            //summation(5, 5);
            //Console.WriteLine("Press any key to Exit");
            //Variables_Demo();
            //Scope_Demo();
            //Naming_Demo();
            //ValueTypes_Demo();
            referenceTypes_Demo();
            Console.ReadKey();
        }

        #region Comments In C#:
        //This Single Line Comment
        // It Used to help Developers in understanding codes
        /*
         * This is multi line comments
         * 
         */

        /// <summary>
        /// This xml document
        /// </summary>
        static void Comment_Demo()
        {
            Console.WriteLine("=== Comments ===");
            Console.WriteLine("welcome, students");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int summation(int a,int b)
        {
            return a + b;
        }
        #endregion

        #region Variables In C#:
        //in methods and classes we write by pasacal 
        static void Variables_Demo()
        {
            //in variables we write by camel case
            string studentName = "Tasneem";
            int studentAge = 23;
            double studentGpa = 3.27;
            //int 3X = 5; //wrong
            Console.WriteLine($"Name:{studentName} , Age : {studentAge} , GPA: {studentGpa}");

                
        }
        #endregion

        #region Variable Scope In ( Class - Method - Block):
        //class visible variable -> Field is seen by every method in the class
        static string schoolName = "Cairo unversity";


        static void Scope_Demo()
        {
            //mehtod level variable only seen inside the method
            Console.WriteLine("=== variable Scope ===");
            string name = "Sara";

            Console.WriteLine($"{name} is studied in {schoolName}");

            if (true)
            {
                int bonusPoints = 5;
                Console.WriteLine($"bonus is {bonusPoints}");
            }
            // we cannot use bonus points outside the block its only accessible inside the block

            Console.WriteLine($"student {name} is still visible as we still inside the method");
        }

        #endregion

        #region Naming Things In C#:
        static void Naming_Demo()
        {
            Console.WriteLine("=== Naming Things ===");
            //Local Variables and Paramenters -> CamelCase
            int studentScore = 90;

            //Classes , Methods , Properties -> Pascal Case
            Student student = new Student();
            student.FullName = "Tasneem Gomaa";
            student.PrintInfo();

            Console.WriteLine($"the student score is {studentScore}");
        }
        #endregion

        #region ValueTypes:

        // value types holds data directly if copying happened it copy only the value or data
static void ValueTypes_Demo()
        {

             int age = 23;
            double gpa = 3.27;
            bool isParsed = true;
            char grade = 'A';
            int copiedAge = age;
            copiedAge = 25;
            Console.WriteLine($"the age is {age} and the copied age is {copiedAge}");

        }

        #endregion

        #region ReferenceTypes:

        // reference types holds pointer that point to the data in heap and copies it make it copy its reference in stack

        static void referenceTypes_Demo()
        {
            Console.WriteLine("=== Reference Types ===");

            Student student01 = new Student();
            student01.FullName = "Rana";
            Student student02 = student01;
            student02.FullName = "Tasneem";

            Console.WriteLine($" student one full name { student01.FullName}");
            Console.WriteLine($" student two full name {student02.FullName}");
            Console.WriteLine("both is changed because the two have refernce same ");

        }
        #endregion
    }
}
