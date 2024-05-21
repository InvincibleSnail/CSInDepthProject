using System.Reflection;

namespace CSInDepthProject.ChapterTen;

public static class NullUtil
{
    public static bool IsNull(this object x)
    {
        return x == null;
    }
}

public static class MyClassUtil
{
    public static void MyFunc(this MyClassBase myClass)
    {
        Type t = myClass.GetType();
        MethodInfo methodInfo = t.GetMethod(nameof(MyFunc));
        if (methodInfo != null)
        {
            myClass.MyFunc();
        }
        else
        {
            Console.WriteLine("static my func~~~");
        }
    }
}

public class MyClassBase
{
}

public class MyClassA : MyClassBase
{
    public void MyFunc()
    {
        Console.WriteLine("its my func!!!");
    }
}

public class MyClassB : MyClassBase
{
}