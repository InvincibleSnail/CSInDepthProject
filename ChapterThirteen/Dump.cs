namespace CSInDepthProject.ChapterThirteen;

public class Dump
{
    public static int CONSTNUM = 0;
    private static object locker = new object();

    public static void DumpFunc(int x, int y)
    {
        Console.WriteLine(x.ToString() + ',' + y.ToString());
        Thread t1 = new Thread(ConstAdd);
        Thread t2 = new Thread(ConstAdd);
        Thread t3 = new Thread(ConstAdd);
        t1.Start();
        t2.Start();
        t3.Start();
    }

    private static void ConstAdd()
    {
        lock (locker)
        {
            CONSTNUM++;
            Console.WriteLine(CONSTNUM);
        }
    }
}