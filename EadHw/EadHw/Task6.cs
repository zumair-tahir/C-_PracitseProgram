//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EadHw
//{
//    class subject 
//    {
//        public double number;
//        public char gradeLetter;
//        public double grade;

//        public  subject(double number) { this.number = number; calGrade(); }
//        public double getGrade() { return grade; }
//        public void calGrade() 
//        {
//            if (number < 50)
//                grade = 0.0;
//            else if (number < 55)
//                grade = 1.0;
//            else if (number < 58)
//                grade = 1.7;
//            else if (number < 61)
//                grade = 2.0;
//            else if (number < 65)
//                grade = 2.3;
//            else if (number < 70)
//                grade = 2.7;
//            else if (number < 75)
//                grade = 3.0;
//            else if (number < 80)
//                grade = 3.3;
//            else if (number < 85)
//                grade = 3.7;
//            else
//                grade = 4.0;
//        }

//    }
//    class semester 
//    {
//        public subject[] listOfSubjects;
//        public int numOfSubjects, count;
//        public semester(int numOfSubjects) 
//        {
//            count=0;
//            this.numOfSubjects = numOfSubjects;
//            listOfSubjects = new subject[numOfSubjects];
//        }

//        public void addSubjectNumber(double number)
//        {
//            listOfSubjects[count++]=new subject(number);
//        }

//        public double getGPA(int CreditHour)
//        {
//            double gpa=0.0;
//            for (int i = 0; i < numOfSubjects; i++)
//            {
//                gpa = gpa + listOfSubjects[i].getGrade()*CreditHour;
//            }


//                return gpa/(CreditHour*numOfSubjects);
//        }

//    }

//    class Task6
//    {
//        static void Main(string[] args)
//        {
//            semester seventh =new semester(5);
//            seventh.addSubjectNumber(80);
//            seventh.addSubjectNumber(75);
//            seventh.addSubjectNumber(65);   
//            seventh.addSubjectNumber(90);
//            seventh.addSubjectNumber(60);
         

//            Console.WriteLine("The GPA of Seventh Semester Credit Hour 3: "+seventh.getGPA(3));
//            Console.ReadLine();
//        }


//    }
//}
