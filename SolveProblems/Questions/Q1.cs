namespace SolveProblems.Questions
{
    public class Q1
    {
        // Example input:
        // 522 3
        // 123 5
        // 123 1
        // 234 2
        // R: 123
        public static string HighestAvg(int n, int[][] ratings)
        {
            int[][] hAvg = new int[n][];
            int[] maioresMedias = new int[n];
            int maior = 0, menorId = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (hAvg[j] == null)
                    {
                        hAvg[j] = ratings[j];
                    }
                    else
                    {
                        if (hAvg[j][0] == ratings[i][0])
                        {
                            hAvg[j][1] = (hAvg[j][1] + ratings[i][1]) / 2;
                        }
                    }


                }
            }

            for (int i = 0; i < n; i++)
            {
                if (hAvg[i][1] >= maior)
                {
                    maior = hAvg[i][1];
                    maioresMedias[i] = hAvg[i][0];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (maioresMedias[i] != 0 && maioresMedias[i] < menorId)
                {
                    menorId = maioresMedias[i];
                }
            }

            return menorId.ToString();
        }
    }
}
