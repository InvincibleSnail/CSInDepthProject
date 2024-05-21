using System.Linq.Expressions;
using System.Text;
using CSInDepthProject.ChapterNight;

namespace CSInDepthProject;

class Programw
{
    static void PrintTValue<T>(T t)
    {
        Console.WriteLine(t);
    }
    static void Main(string[] args)
    {
        PrintTValue<ExpressionTest>(new ExpressionTest());
    }
}