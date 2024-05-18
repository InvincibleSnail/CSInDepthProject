using System.Text;
using CSInDepthProject.ChapterSix;

namespace CSInDepthProject;

class Programw
{
    private static int[] timetable = new int[] { 1, 2, 3 };

    private static int i = 0;

    public static IEnumerable<int> daterange
    {
        get
        {
            for (; i < timetable.Length; ++i)
            {
                yield return timetable[i];
            }
        }
    }

    static void Main(string[] args)
    {
        foreach (var day in daterange)
        {
            Console.WriteLine(day);
        }
    }
}