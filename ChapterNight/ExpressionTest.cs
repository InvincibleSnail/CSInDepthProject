﻿using System.Linq.Expressions;

namespace CSInDepthProject.ChapterNight;

public class ExpressionTest
{
    public ExpressionTest()
    {
        Expression firstArg = Expression.Constant(2);
        Expression secondArg = Expression.Constant(3);
        Expression add = Expression.Add(firstArg, secondArg);
        Func<int> compiled = Expression.Lambda<Func<int>>(add).Compile();
        Console.WriteLine(compiled());
    }
}