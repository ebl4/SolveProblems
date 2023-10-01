namespace ConsoleApp1.Questions
{
    public class Q2
    {
        public static string Time(long sec)
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
    }
}
