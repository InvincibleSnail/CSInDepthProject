namespace CSInDepthProject.ChapterFive;

public class ClosureTest
{
    public delegate void MethodInvoker();

    public MethodInvoker EnclosingMethod()
    {
        int outerVariable = 5;
        string capturedVariable = "";
        if (DateTime.Now.Hour == 23)
        {
            int nomalLocalVariable = DateTime.Now.Minute;
            Console.WriteLine(nomalLocalVariable);
        }

        MethodInvoker x = delegate()
        {
            string anonLocal = "local to anonymous method";
            Console.WriteLine(capturedVariable + anonLocal);
        };
        capturedVariable = "captured";
        return x;
    }

    public static MethodInvoker createDelegateInstance()
    {
        int counter = 5;
        MethodInvoker ret = delegate
        {
            Console.WriteLine(counter);
            counter++;
        };
        ret();
        return ret;
    }
}