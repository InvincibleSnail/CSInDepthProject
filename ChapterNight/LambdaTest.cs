namespace CSInDepthProject.ChapterNight;

public class LambdaTest
{
    private Func<string, int> returnLength;

    public LambdaTest()
    {
        returnLength = delegate(string text) { return text.Length; };
        Console.Write(returnLength("hello"));
        returnLength = s => s.Length;
        Console.Write(returnLength("ooo"));
    }
}