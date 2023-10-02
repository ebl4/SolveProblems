using SolveProblems.Questions;

int[][] ratings = new int[][] {
    new int[] { 522, 3 }, new int[] { 123, 5},
    new int[] { 123, 1}, new int[] { 234, 2}
};

int[] array = new int[] { 2, 4, 6, 36 };

var singers = new long[] { 1, 1, 2, 2, 3, 3, 4 };

//Console.WriteLine(Q1.HighestAvg(4, ratings));

//Console.WriteLine(Q2.Time(7000));

//Q3.AllPinVariations("11");

//Q4.SubArraysCubePerfect(array);

//Q5.SameMiddle();

Console.WriteLine(Q6.FavouriteSinger(singers.Length, singers));


