namespace CodeforcesProblems.Contests;

internal sealed class Contest2032
{
    // https://codeforces.com/contest/2032/problem/A
    internal static void ProblemA()
    {
        int numOfSets = int.Parse(Console.ReadLine());
        for (int i = 0; i < numOfSets; i++)
        {
            int min = -1, max = -1;
            int numOfLamp = int.Parse(Console.ReadLine());
            int[] switches = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int turnedOn = switches.Where(x => x == 1).Count();
            min = turnedOn & 1;
            max = turnedOn < numOfLamp * 2 - turnedOn ? turnedOn : numOfLamp * 2 - turnedOn;
            Console.WriteLine($"{min} {max}");
        }
    }
}
