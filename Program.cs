using System.Linq.Expressions;
using System.Text;
using CSInDepthProject.ChapterTen;

namespace CSInDepthProject;

class Programw
{
    static void Main(string[] args)
    {
        MyClassA myClassA = new MyClassA();
        MyClassB myClassB = new MyClassB();
        myClassA.MyFunc();
        myClassB.MyFunc();
    }
}