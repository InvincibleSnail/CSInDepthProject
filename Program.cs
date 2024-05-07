using System.Text;
using CSInDepthProject.ChapterThree;

namespace CSInDepthProject;

class A
{
}

class B : A
{
}

class Program
{
    static void Main(string[] args)
    {
        static void SetObject(A a)
        {
            
        }

        Action<A> actObject = SetObject;
        Action<B> actString = actObject;
    }
}