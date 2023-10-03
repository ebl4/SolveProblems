namespace SolveProblems.Questions
{
    public class Q7
    {
        public static char[][] Init(int n, int m)
        {
            var table = new char[n][];
            for (int i = 0; i < n; i++)
            {
                table[i] = new char[m];
                for (int j = 0; j < m; j++)
                {
                    table[i][j] = (char) Console.Read();
                }
                Console.ReadLine();
            }

            return table;
        }


        public static int Solve(int n, int m)
        {
            var table = Init(n, m);
            int darkCells = 0, maxDarkCellsLine = 0, maxDarkCellsCol = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (table[i][j] == '#')
                    {
                        darkCells++;
                    }
                    else
                    {
                        if (darkCells > maxDarkCellsLine) maxDarkCellsLine = darkCells;
                        darkCells = 0;
                    }
                }
            }

            darkCells = 0;

            // Percorre por colunas
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (table[j][i] == '#')
                    {
                        darkCells++;
                    }
                    else
                    {
                        if (darkCells > maxDarkCellsCol) maxDarkCellsCol = darkCells;
                        darkCells = 0;
                    }
                }
            }

            return Math.Max(maxDarkCellsLine, maxDarkCellsCol);
        }
    }
}
