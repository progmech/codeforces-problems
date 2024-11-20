namespace CodeforcesProblems.Contests;

internal sealed class Contest2033
{
    private static string winKosuke = "Kosuke";
    private static string winSakurako = "Sakurako";
    internal static string Name = "Task 2033A (Sakurako And Kosuke)";

    // https://codeforces.com/problemset/problem/2033/A
    internal static void ProblemA()
    {
        string winner = "";
        int numOfAttempt = int.Parse(Console.ReadLine());
        for (int j = 0; j < numOfAttempt; j++)
        {
            int winResult = int.Parse(Console.ReadLine());
            int i = 0;
            int x = 0;
            while (Math.Abs(x) != winResult)
            {
                int shift = 2 * i - 1;
                if (i % 2 == 0)
                {
                    x += shift;
                    winner = winKosuke;
                }
                else
                {
                    x -= shift;
                    winner = winSakurako;
                }
                i++;
            }
            Console.WriteLine(winner);
        }
    }
}
