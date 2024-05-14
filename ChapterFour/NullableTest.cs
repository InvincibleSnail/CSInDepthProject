namespace CSInDepthProject.ChapterFour;

public class NullableTest
{
    public static void Display(Nullable<int> x)
    {
        Console.WriteLine("has value: {0}", x.HasValue);
        if (x.HasValue)
        {
            Console.WriteLine("value: {0]", x.Value);
            Console.WriteLine("explict conversion: {0}", (int)x);
            Console.WriteLine("get value or default: {0}", x.GetValueOrDefault());
            Console.WriteLine("to string: {0}", x.ToString());
            Console.WriteLine("get hash code: {0}", x.GetHashCode());
        }
    }
}