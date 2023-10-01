namespace ConsoleApp1.Questions
{
    public class Q5
    {
        // URL Question: https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/equal-median-8aba723b/
        public static void SameMiddle()
        {
            int i, j;
            int T = 1, N = 11;
            int aux;

            for (i = 0; i < T; i++)
            {

                int[] A = new int[] { 3, 5, 8, 10, 13, 15, 18, 22, 22, 30, 33 };
                int[] B = new int[] { 2, 5, 6, 9, 10, 15, 16, 16, 18, 30, 32 };
                int swap = 0;

                int m = N / 2;

                while (A[m] != B[m] && swap <= N)
                {
                    int indexA = 0, indexB = N - 1;
                    swap++;

                    // troca
                    aux = A[0];
                    A[0] = B[N - 1];
                    B[N - 1] = aux;

                    while (indexA < N - 1 && A[indexA] > A[indexA + 1])
                    {
                        // troca
                        aux = A[indexA];
                        A[indexA] = A[indexA + 1];
                        A[indexA + 1] = aux;
                        indexA++;
                    }

                    while (indexB > 0 && B[indexB] < B[indexB - 1])
                    {
                        // troca
                        aux = B[indexB];
                        B[indexB] = B[indexB - 1];
                        B[indexB - 1] = aux;
                        indexB--;
                    }
                }

            }
        }
    }
}
