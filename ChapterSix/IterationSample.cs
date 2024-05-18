using System.Collections;

namespace CSInDepthProject.ChapterSix;

public class IterationSample : IEnumerable
{
    public object[] values;
    public int startingPoint;

    public IterationSample(object[] values, int startingPoint)
    {
        this.values = values;
        this.startingPoint = startingPoint;
    }

    public IEnumerator GetEnumerator()
    {
        // return new IterationSampleIterator(this);
        for (int i = 0; i < values.Length; ++i)
        {
            yield return values[(i + startingPoint) % values.Length];
        }
    }
}