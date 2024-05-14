namespace CSInDepthProject.ChapterFive;

public class DelegateTest
{
    public static Action<int> Action = x => { Console.WriteLine(x); };
    public static Func<int, int> Func = x => { return 2 * x; };

    public delegate void MulticastDelegate(int x);
}