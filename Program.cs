using System.Text;
using CSInDepthProject.ChapterFive;

namespace CSInDepthProject;

class Programw
{
    static void t(int x)
    {
        Console.WriteLine(x);
    }
    static void Main(string[] args)
    {
        Predicate<int> p = i => i > 0;
        Console.WriteLine(p(-1));
    }
}