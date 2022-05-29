

namespace ConsoleApp1
{
    class swap
    {
        static void Main1(string[] args)
        {
            int x = 5, y = 6;
            Console.WriteLine("before swapping\n"a = " + a + "b" + y);
             swap(x, y);
        }
        static void swap(int a, int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("in swap method \na=" + a + "b=" + b);
        }
        static void sample(int z, out int s)
        {
            s = z + 1;
        }
        static int x()
        {
            return 1;
        }
        static void x1(out int s1, out int s2, out int s3)
        {
            s1 = 1;
            s2 = 1;
            s3 = 1;
        }
    }
}
