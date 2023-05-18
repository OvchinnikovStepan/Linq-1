namespace Linq_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 4, -8, 3, -1,-2,11 };
            IEnumerable<int> F1= from x in A where x<0 select x;
            Console.WriteLine(F1.Count());
            IEnumerable<int> F2 = from x in A where x > 0 select x;
            Console.WriteLine(F2.Sum());
            IEnumerable<int> F3 = from x in A where (x/2 * 2 == x) select x;
            int M = 1;
            foreach (int x in F3) { M = M * x; }
            Console.WriteLine(M);
        }
    }
}