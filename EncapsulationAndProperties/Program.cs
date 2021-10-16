using System;

namespace EncapsulationAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Students stu1 = new Students();
            stu1.StudentNo = 49;
            stu1.StudentName = "John";
            stu1.StudentSurname = "Anderson";
            stu1.ClassNo = 3;
            stu1.StudentsInfo();

            Students stu2 = new Students(63, "Mike", "Stinson", 5);
            stu2.StudentsInfo();

            stu1.GradeUp();
            stu1.StudentsInfo();

            stu2.GradeDown();
            stu2.StudentsInfo();

            Students stu3 = new Students(24, "Joey", "Geller", 1);
            stu3.GradeDown();
            stu3.StudentsInfo();
        }
    }

    class Students
    {
        private string type = "Student";
        private int studentNo;
        private string studentName;
        private string studentSurname;
        private int classNo ;

        //Cann't be set since setter is not initialised.
        public string Type { get => type; }
        public int StudentNo
        {
            get
            {
                return studentNo;
            }
            set
            {
                studentNo = value;
            }
        }

        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentSurname { get => studentSurname; set => studentSurname = value; }

        public int ClassNo {
            get => classNo;
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("Class cann't be lower than 1");
                    classNo = 1;
                }
                else
                {
                    classNo = value;
                }
            }
        }

        public Students(int studentNo, string studentName, string studentSurname, int classNo)
        {
            StudentNo = studentNo;
            StudentName = studentName;
            StudentSurname = studentSurname;
            ClassNo = classNo;
        }

        public Students()
        {

        }

        public void StudentsInfo()
        {
            Console.WriteLine("    Student Information");
            Console.WriteLine("Persons type:    {0}", type);
            Console.WriteLine("Student number:  {0}", StudentNo);
            Console.WriteLine("Student name:    {0}", StudentName);
            Console.WriteLine("Student surname: {0}", StudentSurname);
            Console.WriteLine("Class number:    {0}", ClassNo);
        }

        public void GradeUp()
        {
            this.classNo += 1;
        }

        public void GradeDown()
        {
            this.ClassNo -= 1;
        }
    }
}
