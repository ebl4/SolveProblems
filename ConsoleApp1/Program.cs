Console.WriteLine(Time(7000));

int[][] ratings = new int[][] {
    new int[] { 522, 3 }, new int[] { 123, 5},
    new int[] { 123, 1}, new int[] { 234, 2}
};

Console.WriteLine(HighestAvg(4, ratings));
SameMiddle();


// URL Question: https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/equal-median-8aba723b/
void SameMiddle()
{
    int i, j;
    int T = 1, N = 11;
    int aux;

    for (i = 0; i < T; i++)
    {

        int[] A = new int[] { 3 ,5 ,8 ,10 ,13, 15 ,18 ,22 ,22 ,30 ,33 };
        int[] B = new int[] { 2 ,5 ,6 ,9 ,10 ,15 ,16, 16 ,18, 30, 32 };
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

            while (indexA < N-1 && A[indexA] > A[indexA + 1])
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

// Example input:
// 522 3
// 123 5
// 123 1
// 234 2
// R: 123
string HighestAvg(int n, int[][] ratings)
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

string Time(long sec)
{
    string resp = "";
    long y = 0, d = 0, h = 0, m = 0, s = 0;

    if (sec == 0) return "now";

    m = sec / 60;

    if (m >= 60)
    {
        h = m / 60;
        if (h >= 24)
        {
            d = h / 24;
            if (d >= 365)
            {
                y = d / 365;
                d = d % 365;
            }
            h = h % 24;
        }
        m = m % 60;
    }

    s = sec - y * 60 * 60 * 24 * 365 - d * 60 * 60 * 24 - h * 60 * 60 - m * 60;

    if (d > 1)
    {
        resp += d;
        resp += " dias ";
    }
    else if (d == 1)
    {
        resp += "1 dia ";
    }

    if (h > 1)
    {
        resp += h;
        resp += " horas ";
    }
    else if (h == 1)
    {
        resp += "1 hora ";
    }

    if (m > 1)
    {
        resp += m;
        resp += " minutos ";
    }
    else if (m == 1)
    {
        resp += "1 minuto ";
    }

    if (s > 1)
    {
        resp += s;
        resp += " segundos ";
    }
    else if (s == 1)
    {
        resp += "1 segundo ";
    }


    return resp;
}