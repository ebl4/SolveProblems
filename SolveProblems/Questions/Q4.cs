namespace SolveProblems.Questions
{
    public class Q4
    {
        public static bool CubeRoot(int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                if (i * i * i == n) return true;
            }
            return false;
        }
        public static void SubArraysCubePerfect(int[] array)
        {
            int cont = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    var prod = 1;
                    for (int k = i; k <= j; k++)
                    {
                        prod *= array[k];
                        //Console.Write(array[k] + " ");
                    }
                    if (i <= j)
                    {
                        if (CubeRoot(prod)) cont++;
                    }
                    //Console.WriteLine(prod);
                }
            }
            Console.WriteLine(cont);
        }
    }
}
