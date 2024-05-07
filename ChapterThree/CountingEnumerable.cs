using System.Collections;

namespace CSInDepthProject.ChapterThree;

public class CountingEnumerable : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        return new CountingEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class CountingEnumerator : IEnumerator<int>
{
    private int current = -1;

    public bool MoveNext()
    {
        current++;
        return current < 10;
    }

    public void Reset()
    {
        current = -1;
    }

    public int Current
    {
        get { return current; }
    }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }
}