

namespace ConsoleApp1
{
    class propertiesInClass
    {
        public propertiesInClass(int a)
        {
            rn = a;
        }
        private int rn = 101;

        public int rn
        {
            get
            {
                return rn; 
            }
        }

    }
    class class3
    {
        public static void Main()
        {
            propertiesInClass p = new propertiesInClass(2);
            System.Console.WriteLine(p.rn);
        }
    }
}
