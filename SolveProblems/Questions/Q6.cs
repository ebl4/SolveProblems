namespace SolveProblems.Questions
{
    public class Q6
    {
        public static int FavouriteSinger(long n, long[] songs)
        {
            // Dictioray that contain a key with ith singer and the value equal to times
            // the singer appears in the array
            var singers = new Dictionary<long, long>();

            for (int i = 0; i < n; i++)
            {
                if (!singers.ContainsKey(songs[i]))
                {
                    singers.Add(songs[i], 1);
                }
                else
                {
                    singers[songs[i]]++;
                }
            }

            var result = singers.Max(s => s.Value);
            var count = singers.Count(v => v.Value == result);

            return count;
        }
    }
}
