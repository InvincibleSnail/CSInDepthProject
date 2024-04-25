using System.Collections;

namespace CSInDepthProject.ChapterOne;

public class ProductNameComparer : IComparer<Product>
{
    public int Compare(Product x, Product y)
    {
        Product first = x;
        Product second = y;
        return first.Name.CompareTo(second.Name);
    }
}