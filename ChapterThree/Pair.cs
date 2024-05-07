namespace CSInDepthProject.ChapterThree;

public class Pair<T1, T2>  
{  
    // 静态方法 Of 用于创建 Pair 的实例  
    // 注意：由于 Pair 现在是静态的泛型类，我们通常不会这样做  
    // 更好的做法可能是有一个非静态的泛型类，并提供一个静态的工厂方法或构造函数 
    private Pair(T1 f, T2 s)
    {
        
    }
    
    public Pair<T1, T2> Of(T1 first, T2 second)  
    {  
        // 假设我们有一个嵌套的非静态泛型类实例（下面将展示）  
        return new Pair<T1,T2>(first, second);  
    }  
}  