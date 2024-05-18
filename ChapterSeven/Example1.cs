namespace CSInDepthProject.ChapterSeven;

partial class Example<TFirst, TSecond> : IEquatable<string> where TFirst : class
{
    protected bool Equals(Example<TFirst, TSecond> other)
    {
        throw new NotImplementedException();
    }

    public bool Equals(string? other)
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Example<TFirst, TSecond>)obj);
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}