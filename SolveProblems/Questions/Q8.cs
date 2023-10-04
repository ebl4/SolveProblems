namespace SolveProblems.Questions
{
    public class Q8
    {
        public static int Solve(int[] a, int[] b)
        {
            int min = 5001;
            int i = 0, n = a.Length, steps = 0;

            for (int j = 0; j < n; j++)
            {
                if (a[i] < min) min = a[i];
            }

            while (i < n)
            {
                while (a[i] > min)
                {
                    a[i] -= b[i];
                    steps++;
                }
                if (a[i] < min)
                {
                    min = a[i];
                    i = 0;
                }
                else if (a[i] < 0)
                {
                    return -1;
                }
                else i++;
            }

            return steps;
        }

        public static void Main(string[] args)
        {
            var inputFile = File.ReadLines("/input3.txt");
            int n = int.Parse(inputFile.ElementAt(0));
            string[] line = inputFile.ElementAt(1).Split(" ");
            var a = new int[n];
            var b = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(line[i]);
            }

            line = inputFile.ElementAt(2).Split(" ");

            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(line[i]);
            }

            Console.WriteLine(Solve(a, b));
        }
    }
}
