namespace ConsoleApp1
{
    // 0 -> 0, 8
    // 1 -> 1, 2, 4
    // 2 -> 1, 2, 3, 5
    // 3 -> 2, 3, 6
    // 4 -> 1, 4, 5, 7
    // 5 -> 2, 4, 5, 6, 8
    // 6 -> 3, 5, 6, 9
    // 7 -> 4, 7, 8
    // 8 -> 5, 7, 8, 9, 0
    // 9 -> 6, 8, 9
    public class Q3
    {
        public static int[][] getAdjacentList()
        {
            return new int[][] { new int[] { 0, 8 }, new int[] { 1, 2, 4 },
                new int[] { 1, 2, 3, 5 }, new int[] { 2, 3, 6 }, new int[] { 1, 4, 5, 7 },
                new int[] { 2, 4, 5, 6, 8 }, new int[] { 3, 5, 6, 9 }, new int[] { 4, 7, 8 },
                new int[] { 5, 7, 8, 9, 0 }, new int[] { 6, 8, 9} };

        }

        public static void visit(int[][] variacoes, int i)
        {
            if (i < variacoes.Length)
            {
                for (int j = 0; j < variacoes[i].Length; j++)
                {
                    Console.Write(variacoes[i][j]);
                    visit(variacoes, i + 1);
                }
            }
        }

        public static void AllPinVariations(string input)
        {
            var adjList = getAdjacentList();
            var inputSize = input.Length;

            var variacoes = new int[inputSize][];

            for (int i = 0; i < inputSize; i++)
            {
                int digit = (int)input[i]-48;
                variacoes[i] = adjList[digit];
            }

            visit(variacoes, 0);
        }
    }
}
