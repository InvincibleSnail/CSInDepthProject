using System.Collections;
using CSInDepthProject.ChapterOne;

namespace CSInDepthProject;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = Product.GetSampleProducts();
        // list.FindAll(p => p.Price > 10).ForEach(Console.WriteLine);
        foreach (var VARIABLE in list.Where(p => p.Price == null))
        {
            Console.WriteLine(VARIABLE);
        }
    }
}