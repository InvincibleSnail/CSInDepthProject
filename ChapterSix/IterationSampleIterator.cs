using System.Collections;

namespace CSInDepthProject.ChapterSix;

public class IterationSampleIterator : IEnumerator
{
    private IterationSample parent;
    private int position;

    internal IterationSampleIterator(IterationSample parent)
    {
        this.parent = parent;
        position = -1;
    }

    public bool MoveNext()
    {
        if (position != parent.values.Length)
        {
            position++;
        }

        return position < parent.values.Length;
    }

    public void Reset()
    {
        position = -1;
    }

    public object Current
    {
        get
        {
            if (position == -1 || position == parent.values.Length)
            {
                throw new InvalidOperationException();
            }

            int index = position + parent.startingPoint;
            index = index % parent.values.Length;
            return parent.values[index];
        }
    }
}