

namespace ConsoleApp1
{
    class student1
    {
        public string sname;
        public int sid;
        public string classname;
        public void Getdata()
        {
            Console.WriteLine("Enter student Name");
            sname = Console.ReadLine();
            Console.WriteLine("Enter student id");
            sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student classname");
            classname = Console.ReadLine();
        }

        public void printdata()
        {
            Console.WriteLine("student name" + sname);
            Console.WriteLine("student id" + sid);
            Console.WriteLine("student classname" + classname);
        }
        static void Main1(string[] args)
        {
            student1[] studentlist = new student1[3];
            for (int i = 0; i < studentlist.Length; i++)
            {
                student1 s = new student1();
                s.Getdata();
                studentlist[i] = s;
            }
            for (int i = 0; i < studentlist.Length; i++)
            {
                studentlist[i].printdata();
            }
        }
    }
}
