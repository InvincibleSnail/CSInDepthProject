using System.Linq.Expressions;
using System.Text;
using CSInDepthProject.ChapterElevenAndTwelve;
using CSInDepthProject.ChapterTen;
using CSInDepthProject.ChapterThirteen;

namespace CSInDepthProject;

class Programw
{
    static void Main(string[] args)
    {
        Dump.DumpFunc(1, 2);
        Console.WriteLine(Dump.CONSTNUM);
        Event.Click += (sender, eventArgs) => { return; };
        // Event.Click(new object(),EventArgs.Empty);
    }
}